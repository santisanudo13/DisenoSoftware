package p8;

import java.sql.*;

import p8.excepciones.NoSeHaPodidoConectarABBDD;


/**
 * Pool de conexiones
 *
 */
public class ConnectionPool {
	
	private static ConnectionPool poolInstance;
	
	private Estrategia estrategia;

	/**
	 * Metodo estatico para obtener la instancia unica del pool
	 * @param estrategia
	 * @return connection pool
	 */
	public static ConnectionPool getInstance(Estrategia estrategia){
		if(poolInstance == null){
			poolInstance = new ConnectionPool(estrategia);
		}
		poolInstance.setEstrategia(estrategia);
		return poolInstance;
	}
	
	/**
	 * Constructor de la clase ConnectionPool
	 * @param estrategia
	 */
	private ConnectionPool(Estrategia estrategia){
		this.estrategia = estrategia;
	}
	
	/**
	 * Metodo que permite obtener una conexion
	 * @return conexion
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public Connection solicitarConexion() throws NoSeHaPodidoConectarABBDD{
		return estrategia.solicitarConexion();
	}
	
	/**
	 * Metodo que permite devolver una conexion obtenida previamente
	 * @return conexion
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public void devolverConexion(Connection connection) throws NoSeHaPodidoConectarABBDD{
		estrategia.devolverConexion(connection);
	}
	
	/**
	 * Metodo que permite establecer la estrategia a utilizar
	 * @param estrategia
	 */
	public void setEstrategia(Estrategia estrategia) {
		this.estrategia = estrategia;
	}
	
	/**
	 * Metodo para cerrar todas las conexiones
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public void cerrarConexiones() throws NoSeHaPodidoConectarABBDD{
		estrategia.cerrarConexiones();
	}
	
}
