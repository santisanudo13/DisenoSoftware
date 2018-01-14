package datamappers;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import domain.*;
import keyGenerator.*;
import p8.*;
import p8.excepciones.*;
import proxy.*;



/**
 * Data Mapper para las series que contiene las operaciones crud asi como los metodos para poder comprobar el correcto
 * funcionamiento del lozy load implementado.
 *
 */
public class SerieDataMapper {

	private Estrategia estrategia;

	/**
	 * Constructor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public SerieDataMapper() throws NoSeHaPodidoConectarABBDD{
		estrategia = new EstrategiaDinamica(2);
	}

	/**
	 * Metodo que permite insertar una serie en la BBDD
	 * @param s
	 * @return serie insertada o null si no se ha insertado
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public Serie insertSerie(Serie s) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		KeyGenerator keyGenerator = KeyGenerator.getInstance();

		long idSerie = keyGenerator.nextValueSerie();
		Serie serie = null;

		String sql = "INSERT INTO p09diseno.Serie(idSerie,nombre,sinopsis,costoSerie,tipoSerie,idCreador) VALUES(?,?,?,?,?,?)";

		try {
			
			PreparedStatement p;

			p = conn.prepareStatement(sql);
			p.setLong(1, idSerie);
			p.setString(2, s.getNombre());
			p.setString(3, s.getSinopsis());

			Creador creador = s.getCreador();

			if(creador == null || creador.getId() ==0L ){
				p.setNull(6, 0);
			}else{
				p.setLong(6, s.getCreador().getId());
			}

			if(s instanceof SerieEstandarProxy || s instanceof SerieEstandarReal){
				p.setDouble(4, SerieEstandar.getCosto());
				p.setString(5, "Estandar");		
			}else if(s instanceof SerieGoldProxy || s instanceof SerieGoldReal){
				p.setDouble(4, SerieGold.getCosto());
				p.setString(5, "Gold");
			}else if(s instanceof SerieSilverProxy || s instanceof SerieSilverReal){
				p.setDouble(4, SerieSilver.getCosto());
				p.setString(5, "Silver");
			}
			int numModificaciones = p.executeUpdate();
			p.close();

			if(numModificaciones == 1){
				serie = s;
				serie.setId(idSerie);
			}

		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);

		return serie;
	}

	/**
	 * Metodo que permite actualizar una serie en la BBDD
	 * @param s
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public void updateSerie(Serie s) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		String sql = "UPDATE p09diseno.Serie SET nombre=?, sinopsis=?, costoSerie=?, tipoSerie=? where idSerie = ?";

		try {
			PreparedStatement p = conn.prepareStatement(sql);
			p.setString(1, s.getNombre());
			p.setString(2, s.getSinopsis());
			p.setLong(5, s.getId());

			if(s instanceof SerieEstandarProxy || s instanceof SerieEstandarReal){
				p.setDouble(3, SerieEstandar.getCosto());
				p.setString(4, "Estandar");		
			}else if(s instanceof SerieGoldProxy || s instanceof SerieGoldReal){
				p.setDouble(3, SerieGold.getCosto());
				p.setString(4, "Gold");
			}else if(s instanceof SerieSilverProxy || s instanceof SerieSilverReal){
				p.setDouble(3, SerieSilver.getCosto());
				p.setString(4, "Silver");
			}

			p.executeUpdate();
			p.close();
		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);
	}

	/**
	 * Metodo que permite eliminar una serie de la BBDD
	 * @param s
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public void deleteSerie(Serie s) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		String sql = "DELETE FROM p09diseno.Serie WHERE idSerie = ?";

		try {
			PreparedStatement p = conn.prepareStatement(sql);
			p.setLong(1, s.getId());
			p.executeUpdate();
			p.close();
		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);
	}

	/**
	 * Metodo que permite obtener una serie de la BBDD a partir de su identificador
	 * @param id
	 * @return
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public Serie readSerie(long id) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		Serie s = null;

		String sql = "SELECT idSerie, nombre, sinopsis, tipoSerie FROM p09diseno.Serie WHERE idSerie = ?";

		try {

			PreparedStatement p = conn.prepareStatement(sql);
			p.setLong(1, id);
			ResultSet series = p.executeQuery();

			if(series.next()){
				switch(series.getString(4)){
				case "Estandar":
					s =  new SerieEstandarProxy(series.getString(2),series.getString(3));
					break;
				case "Silver":
					s =  new SerieSilverProxy(series.getString(2),series.getString(3));
					break;
				case "Gold":
					s =  new SerieGoldProxy(series.getString(2),series.getString(3));
					break;
				default:
					s = null;
					break;
				}
				s.setId(series.getLong(1));
			}

			p.close();

		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);

		return s;
	}

	/**
	 * Metodo para comprobar el lazy load de serie con respecto a su creador
	 * @param s
	 * @return creador de la serie
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public Creador findSerieCreator(Serie s) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		Creador creador = null;

		String sql = "SELECT c.idCreador, c.nombre, c.apellido1, c.apellido2 FROM p09diseno.Serie s "
				+ "INNER JOIN p09diseno.Creador c ON s.idCreador = c.idCreador WHERE s.idSerie = ?";

		try {

			PreparedStatement p = conn.prepareStatement(sql);
			p.setLong(1, s.getId());
			ResultSet result = p.executeQuery();

			if(result.next()){
				long idCreador = result.getLong(1);
				String nombre = result.getString(2);
				String apellido1 = result.getString(3);
				String apellido2 = result.getString(4);
				creador = new Creador(nombre, apellido1, apellido2);
				creador.setId(idCreador);
			}

			p.close();

		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);

		return creador;
	}
	
	/**
	 * Metodo para comprobar el funcionamiento del lazy load de la serie con respecto a las temporadas
	 * @param s
	 * @return temporadas de la serie
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public List<Temporada> findSerieSeasons(Serie s) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		List<Temporada> temporadas = new ArrayList<Temporada>();

		String sql = "SELECT t.idTemporada,t.numTemporada from p09diseno.Temporada t WHERE t.idSerie = ?";

		try {

			PreparedStatement p = conn.prepareStatement(sql);
			p.setLong(1, s.getId());
			ResultSet result = p.executeQuery();

			while(result.next()){
				long idTemporada = result.getLong(1);
				int numTemporada = result.getInt(2);
				Temporada t = new Temporada(numTemporada,s);
				t.setIdTemporada(idTemporada);
				temporadas.add(t);
			}

			p.close();

		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);

		return temporadas;
	}

	/**
	 * Metodo para comprobar el funcionamiento del lazy load de la serie con respecto a los artistas
	 * @param s
	 * @return artistas que participan en la serie
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public List<Artista> findSerieArtists(Serie s) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(estrategia);
		Connection conn = pool.solicitarConexion();

		List<Artista> artistas = new ArrayList<Artista>();

		String sql = "SELECT a.idArtista, a.nombre,a.apellido1,a.apellido2 FROM p09diseno.Series_Artistas s "
				+ "INNER JOIN p09diseno.Artista a ON s.idArtista = a.idArtista WHERE s.idSerie = ?";

		try {

			PreparedStatement p = conn.prepareStatement(sql);
			p.setLong(1, s.getId());
			ResultSet result = p.executeQuery();

			while(result.next()){
				long idArtista = result.getLong(1);
				String nombre = result.getString(2);
				String apellido1 = result.getString(3);
				String apellido2 = result.getString(4);
				Artista a = new Artista(nombre, apellido1, apellido2);
				a.setId(idArtista);
				artistas.add(a);
			}

			p.close();

		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);

		return artistas;
	}

}
