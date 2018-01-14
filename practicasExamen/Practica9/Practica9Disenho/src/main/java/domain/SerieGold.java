package domain;

/**
 * Serie Gold
 *
 */
public abstract class SerieGold extends Serie{

	private static double costo = 1.5; 

	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public SerieGold(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

	/* Getters y Setters  */

	public static double getCosto() {
		return costo;
	}

	public static void setCosto(double costo) {
		SerieGold.costo = costo;
	}

}

