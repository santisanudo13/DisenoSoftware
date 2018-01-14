

import static org.junit.Assert.assertTrue;

import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.LinkedList;
import java.util.List;

import org.junit.AfterClass;
import org.junit.Test;

import datamappers.SerieDataMapper;
import domain.Artista;
import domain.Creador;
import domain.Serie;
import domain.Temporada;
import p8.ConnectionPool;
import p8.EstrategiaDinamica;
import p8.excepciones.NoSeHaPodidoConectarABBDD;
import proxy.SerieSilverReal;

/**
 * Prueba del data mapper de Series
 *
 */
public class DataMapperTestSilver {

	private static List<Serie> series = new LinkedList<Serie>(); 

	@Test
	public void testInsert() throws NoSeHaPodidoConectarABBDD {

		SerieDataMapper serieDataMapper = new SerieDataMapper();
		Serie serie = new SerieSilverReal("House of Cards", "Bla, bla, bla...");

		Serie serie2 = serieDataMapper.insertSerie(serie);

		assertTrue(serie2.getNombre().equals(serie.getNombre()));
		assertTrue(serie2.getSinopsis().equals(serie.getSinopsis()));
		assertTrue(serie2.getId() == serie.getId());

		series.add(serie);

	}

	@Test
	public void testUpdate() throws NoSeHaPodidoConectarABBDD {

		SerieDataMapper serieDataMapper = new SerieDataMapper();
		Serie serie = new SerieSilverReal("House of Cards", "House of Cards es una serie, bla, bla, bla...");
		serie = serieDataMapper.insertSerie(serie);

		serieDataMapper.updateSerie(serie);

		Serie serie2 = serieDataMapper.readSerie(serie.getId());

		assertTrue(serie2.getNombre().equals(serie.getNombre()));
		assertTrue(serie2.getSinopsis().equals(serie.getSinopsis()));
		assertTrue(serie2.getId() == serie.getId());

		series.add(serie);

	}

	@Test
	public void testSelect() throws NoSeHaPodidoConectarABBDD {

		SerieDataMapper serieDataMapper = new SerieDataMapper();

		Serie serie = new SerieSilverReal("La que se avecina", "Bla, bla, bla...");
		serie = serieDataMapper.insertSerie(serie);

		Serie serie2 = serieDataMapper.readSerie(serie.getId());

		assertTrue(serie2.getNombre().equals(serie.getNombre()));
		assertTrue(serie2.getSinopsis().equals(serie.getSinopsis()));
		assertTrue(serie2.getId() == serie.getId());

		series.add(serie);

	}

	@Test
	public void testDelete() throws NoSeHaPodidoConectarABBDD {

		SerieDataMapper serieDataMapper = new SerieDataMapper();

		Serie serie = new SerieSilverReal("Narcos", "Bla, bla, bla...");
		serie = serieDataMapper.insertSerie(serie);

		serieDataMapper.deleteSerie(serie);

		assertTrue(serieDataMapper.readSerie(serie.getId()) == null);

	}

	@Test
	public void testFindCreator() throws NoSeHaPodidoConectarABBDD, SQLException {

		prepareDataForLazyLoadTest();

		SerieDataMapper serieDataMapper = new SerieDataMapper();

		Serie serie;

		serie = serieDataMapper.readSerie(0);

		Creador c = serie.getCreador();

		assertTrue(c.getNombre().equals("Antonio"));
		assertTrue(c.getApellido1().equals("Perez"));
		assertTrue(c.getApellido2().equals("Poo"));

	}

	@Test
	public void testFindSeasons() throws NoSeHaPodidoConectarABBDD, SQLException {

		prepareDataForLazyLoadTest();

		SerieDataMapper serieDataMapper = new SerieDataMapper();

		Serie serie;

		serie = serieDataMapper.readSerie(0);  

		List<Temporada> temporadas = serieDataMapper.findSerieSeasons(serie);

		Temporada t = temporadas.get(0);

		assertTrue(t.getIdTemporada()==0);
		assertTrue(t.getNumTemporada()==1);
		assertTrue(t.getSerie().getId()==0);

	}

	@Test
	public void testFindArtists() throws NoSeHaPodidoConectarABBDD, SQLException {

		prepareDataForLazyLoadTest();

		SerieDataMapper serieDataMapper = new SerieDataMapper();

		Serie serie; 

		serie = serieDataMapper.readSerie(0);

		List<Artista> artistas = serieDataMapper.findSerieArtists(serie);

		Artista a = artistas.get(0);

		assertTrue(a.getId()==0);
		assertTrue(a.getNombre().equals("Juan"));
		assertTrue(a.getApellido1().equals("Gutierrez"));
		assertTrue(a.getApellido2().equals("Barrado"));

	}

	public static void prepareDataForLazyLoadTest() throws NoSeHaPodidoConectarABBDD, SQLException{
		String sql = "INSERT INTO p09diseno.Serie(idSerie,nombre,sinopsis,costoSerie,tipoSerie,idCreador) VALUES(0,'Serie Prueba Lazy Load','bla,bla,bla',0.75,'Silver',0)"
				+ " ON DUPLICATE KEY UPDATE idSerie=idSerie";
		String sql2 = "INSERT INTO p09diseno.Creador(idCreador,nombre,apellido1,apellido2) VALUES(0,'Antonio','Perez','Poo')"
				+ " ON DUPLICATE KEY UPDATE idCreador=idCreador";
		String sql3 = "INSERT INTO p09diseno.Temporada(idTemporada,numTemporada,idSerie) VALUES(0,1,0)"
				+ " ON DUPLICATE KEY UPDATE idTemporada=idTemporada";
		String sql4 = "INSERT INTO p09diseno.Artista(idArtista,nombre,apellido1,apellido2) VALUES(0,'Juan','Gutierrez','Barrado')"
				+ " ON DUPLICATE KEY UPDATE idArtista=idArtista";
		String sql5 = "INSERT INTO p09diseno.Series_Artistas(idArtista,idSerie) VALUES(0,0)"
				+ " ON DUPLICATE KEY UPDATE idSerie=idSerie";

		ConnectionPool pool = ConnectionPool.getInstance(new EstrategiaDinamica(2));
		Connection conn = pool.solicitarConexion();

		Statement stm = conn.createStatement();

		stm.addBatch(sql2);
		stm.addBatch(sql);
		stm.addBatch(sql3);
		stm.addBatch(sql4);
		stm.addBatch(sql5);

		stm.executeBatch();

		pool.devolverConexion(conn);
	}

	public static void clearDataFromLazyLoadTest() throws NoSeHaPodidoConectarABBDD, SQLException{
		String sql = "DELETE FROM p09diseno.Serie where idSerie=0";
		String sql2 = "DELETE FROM p09diseno.Creador where idCreador=0";
		String sql3 = "DELETE FROM p09diseno.Temporada where idTemporada=0";
		String sql4 = "DELETE FROM p09diseno.Artista where idArtista=0";
		String sql5 = "DELETE FROM p09diseno.Series_Artistas where idArtista=0";

		ConnectionPool pool = ConnectionPool.getInstance(new EstrategiaDinamica(2));
		Connection conn = pool.solicitarConexion();

		Statement stm = conn.createStatement();

		stm.addBatch(sql5);
		stm.addBatch(sql4);
		stm.addBatch(sql3);
		stm.addBatch(sql);
		stm.addBatch(sql2);

		stm.executeBatch();

		pool.devolverConexion(conn);
	}

	@AfterClass
	public static void cleanDB() throws NoSeHaPodidoConectarABBDD, SQLException {

		SerieDataMapper serieDataMapper = new SerieDataMapper();

		for(Serie s:series){
			serieDataMapper.deleteSerie(s);
		}

		clearDataFromLazyLoadTest();

	}

}

