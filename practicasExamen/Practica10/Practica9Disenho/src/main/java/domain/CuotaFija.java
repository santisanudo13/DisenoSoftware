package domain;

/**
 * Cuota Fija
 *
 */
public class CuotaFija extends Cuota{

	private static final double cuotaFija = 20.0;
	
	/**
	 * Constructor
	 * @param usuario
	 */
	public CuotaFija(Usuario usuario) {
		super(usuario);
	}

	/**
	 * Calcula la cuota del usuario
	 */
	@Override
	public double getCuota(Factura factura) {
		return cuotaFija;
	}
	
}
