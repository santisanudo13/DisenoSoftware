package domain;

/**
 * SerieEstandar
 *
 */
public abstract class SerieEstandar extends Serie{

	private static double costo = 0.5; 

	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public SerieEstandar(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

	/* Getters y Setters  */

	public static double getCosto() {
		return costo;
	}

	public static void setCosto(double costo) {
		SerieEstandar.costo = costo;
	}

}

