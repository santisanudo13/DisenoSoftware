package p07Disenyo;

import java.sql.Connection;

import p07Disenyo.excepciones.NoSeHaPodidoConectarABBDD;


/**
 * Estrategia para la solicitud y devolucion de conexiones estatica
 * @author Isaac Gutierrez Rodriguez
 *
 */
public class EstrategiaEstatica extends Estrategia {

	/**
	 * Constructor de la clase EstrategiaEstatica
	 * @param numConexiones
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public EstrategiaEstatica(int numConexiones) throws NoSeHaPodidoConectarABBDD{
		super(numConexiones);
	}

	/**
	 * Metodo para la solicitud de una de las conexiones del pool
	 * @return conexion
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	@Override
	public Connection solicitarConexion(){
		return getConexiones().poll();
	}

	/**
	 * Metodo para la devolucion de una conexion concedida previamente
	 * @param connection
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	@Override
	public void devolverConexion(Connection connection){
		if(getConexiones().size() < numConexiones){
			getConexiones().add(connection);
		}
	}

}

