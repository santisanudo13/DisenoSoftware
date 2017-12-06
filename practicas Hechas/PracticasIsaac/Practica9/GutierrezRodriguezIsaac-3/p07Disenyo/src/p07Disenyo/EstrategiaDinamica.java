package p07Disenyo;

import java.sql.Connection;
import java.sql.SQLException;

import p07Disenyo.excepciones.NoSeHaPodidoConectarABBDD;


/**
 * Estrategia para la solicitud y devolucion de conexiones dinamica
 * @author Isaac Gutierrez Rodriguez
 *
 */
public class EstrategiaDinamica extends Estrategia{

	/**
	 * Constructor de la clase EstrategiaDinamica
	 * @param numConexiones
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public EstrategiaDinamica(int numConexiones) throws NoSeHaPodidoConectarABBDD{
		super(numConexiones);
	}

	/**
	 * Metodo para la solicitud de una de las conexiones del pool
	 * @return conexion
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	@Override
	public Connection solicitarConexion() throws NoSeHaPodidoConectarABBDD{
		Connection connection = null;
		if(!getConexiones().isEmpty()){
			connection = getConexiones().poll();
		} else {
			try {
				connection = getConnection();
			} catch (SQLException e) {
				throw new NoSeHaPodidoConectarABBDD();
			}
		}
		return connection;
	}

	/**
	 * Metodo para la devolucion de una conexion concedida previamente
	 * @param connection
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	@Override
	public void devolverConexion(Connection connection) throws NoSeHaPodidoConectarABBDD {
		if(getConexiones().size() < numConexiones){
			getConexiones().add(connection);
		}
	}

}
