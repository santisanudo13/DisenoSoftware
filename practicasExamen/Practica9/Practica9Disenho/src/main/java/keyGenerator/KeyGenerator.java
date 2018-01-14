package keyGenerator;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import p8.*;
import p8.excepciones.*;

/**
 * Generador de claves
 *
 */
public class KeyGenerator {

	private static KeyGenerator keyGenInstance;

	/**
	 * Constructor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	private KeyGenerator() throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(new EstrategiaDinamica(8));
		Connection conn = pool.solicitarConexion();

		String sql = "CREATE TABLE IF NOT EXISTS p09diseno.KeyMap("
				+ "nombreTabla varchar(50) PRIMARY KEY,"
				+ "clave int NOT NULL DEFAULT 0);";

		String sql2 = "INSERT INTO p09diseno.KeyMap(nombreTabla) values('Series'),('Artista'),('Creador'),('Temporada'),('Capitulo'),"
				+ "('Usuario'),('Visualizacion'),('Factura') ON DUPLICATE KEY UPDATE nombreTabla = nombreTabla;";

		try {
			PreparedStatement p = conn.prepareStatement(sql);
			p.executeUpdate();
			p = conn.prepareStatement(sql2);
			p.executeUpdate();
		} catch (SQLException e) {
			System.out.println(e.getMessage());
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);
	}

	/**
	 * Patron singleton para el generador de claves
	 * @return instancia unica del generador
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public static KeyGenerator getInstance() throws NoSeHaPodidoConectarABBDD{
		if(keyGenInstance == null){
			keyGenInstance = new KeyGenerator();
		}
		return keyGenInstance;
	}

	/**
	 * Obtiene la siguiente clave para las series
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueSerie() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Series");
	}

	/**
	 * Obtiene la siguiente clave para los creadores
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueCreador() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Creador");
	}

	/**
	 * Obtiene la siguiente clave para las temporadas
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueTemporada() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Temporada");
	}

	/**
	 * Obtiene la siguiente clave para los capitulos
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueCapitulo() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Capitulo");
	}

	/**
	 * Obtiene la siguiente clave para los usuarios
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueUsuario() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Usuario");
	}

	/**
	 * Obtiene la siguiente clave para las visualizaciones
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueVisualizacion() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Visualizacion");
	}

	/**
	 * Obtiene la siguiente clave para las facturas
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueFactura() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Factura");
	}

	/**
	 * Obtiene la siguiente clave para los artistas
	 * @return siguiente valor
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public long nextValueArtista() throws NoSeHaPodidoConectarABBDD{
		return nextValueGeneric("Artista");
	}

	/**
	 * Metodo generico para la obtencion de la siguiente clave para la tabla cuyo nombre se pasa como parametro
	 * @param element
	 * @return
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	private long nextValueGeneric(String element) throws NoSeHaPodidoConectarABBDD{
		ConnectionPool pool = ConnectionPool.getInstance(new EstrategiaDinamica(8));
		Connection conn = pool.solicitarConexion();

		String sql = "SELECT clave FROM p09diseno.KeyMap WHERE nombreTabla=?";

		String sql2 = "UPDATE p09diseno.KeyMap set clave=? where nombreTabla=?";

		long idClave;

		try {

			PreparedStatement p = conn.prepareStatement(sql);
			p.setString(1, element);
			ResultSet result = p.executeQuery();
			result.next();
			idClave = result.getLong(1);

			p = conn.prepareStatement(sql2);
			idClave++;
			p.setLong(1, idClave);
			p.setString(2, element);
			p.executeUpdate();

		} catch (SQLException e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
			throw new NoSeHaPodidoConectarABBDD();
		}

		pool.devolverConexion(conn);
		return idClave;
	}

}
