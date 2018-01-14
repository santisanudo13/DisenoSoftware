package domain;

/**
 * Serie Silver
 *
 */
public abstract class SerieSilver extends Serie {

	private static double costo = 0.75; 

	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public SerieSilver(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

	/* Getters y Setters  */

	public static double getCosto() {
		return costo;
	}

	public static void setCosto(double costo) {
		SerieSilver.costo = costo;
	}
}
