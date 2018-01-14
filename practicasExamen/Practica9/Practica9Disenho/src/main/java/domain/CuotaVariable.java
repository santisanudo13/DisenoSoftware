package domain;

/**
 * Cuota Variable
 *
 */
public class CuotaVariable extends Cuota {

	/**
	 * Constructor
	 * @param usuario
	 */
	public CuotaVariable(Usuario usuario) {
		super(usuario);
	}

	/**
	 * Calcula la cuota del usuario en funcion de los capitulos visualizados
	 */
	@Override
	public double getCuota(Factura factura) {

		double cuota = 0.0;

		for(Visualizacion v:factura.getVisualizaciones()){
			cuota += v.getImportePagado();
		}

		return cuota;
	}
}
