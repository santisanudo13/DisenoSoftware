package domain;

import java.util.Date;

/**
 * Visualizacion
 *
 */
public class Visualizacion {

	private Date fecha;

	private Usuario usuario;
	private Capitulo capitulo;
	private double importePagado;

	/**
	 * Constructor
	 * @param fecha
	 * @param usuario
	 * @param capitulo
	 */
	public Visualizacion(Date fecha, Usuario usuario, Capitulo capitulo) {
		this.fecha = fecha;
		this.usuario = usuario;
		this.capitulo = capitulo;
	}

	/* Getters y Setters  */

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

	public Capitulo getCapitulo() {
		return capitulo;
	}

	public void setCapitulo(Capitulo capitulo) {
		this.capitulo = capitulo;
	}

	public double getImportePagado() {
		return importePagado;
	}

}
