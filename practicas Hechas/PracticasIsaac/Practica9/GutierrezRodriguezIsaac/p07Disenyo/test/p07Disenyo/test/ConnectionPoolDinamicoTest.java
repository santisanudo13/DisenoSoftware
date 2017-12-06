package p07Disenyo.test;

import static org.junit.Assert.*;

import java.sql.Connection;

import org.junit.Test;

import p07Disenyo.ConnectionPool;
import p07Disenyo.Estrategia;
import p07Disenyo.EstrategiaDinamica;
import p07Disenyo.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Clase de pruebas para la estrategia dinamica
 * @author Isaac Gutierrez Rodriguez
 *
 */
public class ConnectionPoolDinamicoTest {

	@Test
	public void testObtenerConexion() throws NoSeHaPodidoConectarABBDD {
		int numMaxConexiones = 5;

		Estrategia estrategia = new EstrategiaDinamica(numMaxConexiones);

		ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

		assertTrue(connectionPool.solicitarConexion() != null); 

		connectionPool.cerrarConexiones();
	}

	@Test
	public void testObtenerVariasConexiones() throws NoSeHaPodidoConectarABBDD {
		int numMaxConexiones = 5;

		Estrategia estrategia = new EstrategiaDinamica(numMaxConexiones);

		ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

		for(int i=0;i<numMaxConexiones;i++){
			assertTrue(connectionPool.solicitarConexion() != null); 
		}

		connectionPool.cerrarConexiones();
	}

	@Test
	public void testNoQuedanConexionesDisponibles() throws NoSeHaPodidoConectarABBDD {
		int numMaxConexiones = 0;

		Estrategia estrategia = new EstrategiaDinamica(numMaxConexiones);

		ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

		assertTrue(connectionPool.solicitarConexion() != null); 

		connectionPool.cerrarConexiones();
	}

	@Test
	public void testNoQuedanConexionesDisponibles2() throws NoSeHaPodidoConectarABBDD {
		int numMaxConexiones = 5;

		Estrategia estrategia = new EstrategiaDinamica(numMaxConexiones);

		ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

		for(int i=0;i<numMaxConexiones;i++){
			assertTrue(connectionPool.solicitarConexion() != null); 
		}

		assertTrue(connectionPool.solicitarConexion() != null); 

		connectionPool.cerrarConexiones();
	}

	@Test
	public void testDevolverConexiones() throws NoSeHaPodidoConectarABBDD {
		int numMaxConexiones = 5;

		Estrategia estrategia = new EstrategiaDinamica(numMaxConexiones);

		ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

		Connection connection = connectionPool.solicitarConexion();

		for(int i=0;i<numMaxConexiones-1;i++){
			connectionPool.solicitarConexion(); 
		}

		connectionPool.devolverConexion(connection);

		assertTrue(connectionPool.solicitarConexion() != null); 

		connectionPool.cerrarConexiones();
	}

	@Test
	public void testDevolverConexiones2() throws NoSeHaPodidoConectarABBDD {
		int numMaxConexiones = 1;

		Estrategia estrategia = new EstrategiaDinamica(numMaxConexiones);

		ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

		Connection connection = connectionPool.solicitarConexion();

		connectionPool.devolverConexion(connection);

		assertTrue(connectionPool.solicitarConexion() != null); 
		assertTrue(connectionPool.solicitarConexion() != null); 

		connectionPool.cerrarConexiones();
	}

}
