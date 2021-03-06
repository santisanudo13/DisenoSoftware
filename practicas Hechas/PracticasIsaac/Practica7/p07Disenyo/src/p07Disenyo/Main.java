package p07Disenyo;

import java.sql.Connection;
import java.sql.SQLException;

import p07Disenyo.excepciones.NoSeHaPodidoConectarABBDD;

public class Main {

	public static void main(String[] args){

		int numConexiones = 8;

		Estrategia estrategia;
		try {
			estrategia = new EstrategiaEstatica(numConexiones);
			ConnectionPool connectionPool = ConnectionPool.getInstance(estrategia);

			Connection conn = connectionPool.solicitarConexion();

			conn.close();

		} catch (NoSeHaPodidoConectarABBDD e1) {
			e1.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}


	}

}
