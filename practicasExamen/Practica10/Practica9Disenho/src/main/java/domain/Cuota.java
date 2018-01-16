package domain;

/**
 * Cuota
 *
 */
public abstract class Cuota {
	
	protected Usuario usuario;
	
	/**
	 * Constructor
	 * @param usuario
	 */
	public Cuota(Usuario usuario){
		this.usuario = usuario;
	}

	/* Getters y Setters */
	
	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}
	
	/**
	 * Metodo que calcula la cuota del usuario
	 * @param factura
	 * @return cuota 
	 */
	public abstract double getCuota(Factura factura);
	
}
