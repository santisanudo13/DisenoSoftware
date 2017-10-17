package p07Disenyo;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.LinkedList;
import java.util.Properties;
import java.util.Queue;

import p07Disenyo.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Estrategia abstracta para la solicitud y devolucion de conexiones
 * @author Isaac Gutierrez Rodriguez
 *
 */
public abstract class Estrategia {

	private static final String USERNAME = "p07diseno";
	private static final String PASSWORD = "p07diseno";

	private static final String SERVERNAME = "localhost";
	private static final String PORTNUMBER = "3306";

	private static final String DBMS = "mysql";

	protected int numConexiones;

	private Queue<Connection> conexiones;

	/**
	 * Constructor de la clase Estrategia
	 * @param numConexiones
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public Estrategia(int numConexiones) throws NoSeHaPodidoConectarABBDD{
		this.numConexiones = numConexiones;
		conexiones = new LinkedList<Connection>();
		inicializarPool();
	}

	/**
	 * Metodo para la solicitud de una de las conexiones del pool
	 * @return conexion o null
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public abstract Connection solicitarConexion() throws NoSeHaPodidoConectarABBDD;
	
	/**
	 * Metodo para la devolucion de una conexion concedida previamente
	 * @param connection
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public abstract void devolverConexion(Connection connection) throws NoSeHaPodidoConectarABBDD;

	/**
	 * Getter para la obtencion de la lista de conexiones
	 * @return
	 */
	public Queue<Connection> getConexiones() {
		return conexiones;
	}

	/**
	 * Metodo que crea una nueva conexion y la retorna
	 * @return conexion creada
	 * @throws SQLException
	 */
	protected Connection getConnection() throws SQLException {

		Connection conn = null;

		Properties connectionProps = new Properties();
		connectionProps.put("user", USERNAME);
		connectionProps.put("password", PASSWORD);

		if(DBMS.equals("oracle")){
			try {
				Class.forName("oracle.jdbc.driver.OracleDriver");
				conn = DriverManager.getConnection("jdbc:oracle:thin:@" + SERVERNAME + ":" + PORTNUMBER + ":" + "xe",USERNAME, PASSWORD);
			} catch (ClassNotFoundException e) {
				e.printStackTrace();
			}
		}else if (DBMS.equals("mysql")) {
			try {
				Class.forName("com.mysql.jdbc.Driver");
				conn = DriverManager.getConnection(
						"jdbc:" + DBMS + "://" + SERVERNAME + ":" + PORTNUMBER + "/",
						connectionProps);
			} catch (ClassNotFoundException e) {
				e.printStackTrace();
			}
		}
		return conn;
	}

	/**
	 * Metodo privado para la inicializacion del pool de conexiones
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	private void inicializarPool() throws NoSeHaPodidoConectarABBDD{
		for(int i=0;i<numConexiones;i++){
			try {
				conexiones.add(getConnection());
			} catch (SQLException e) {
				throw new NoSeHaPodidoConectarABBDD();
			}
		}
	}

	/**
	 * Metodo para cerrar todas las conexiones
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public void cerrarConexiones() throws NoSeHaPodidoConectarABBDD{
		for(Connection c:conexiones){
			try {
				c.close();
			} catch (SQLException e) {
				throw new NoSeHaPodidoConectarABBDD();
			}
		}
	}

}
