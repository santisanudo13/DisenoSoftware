package domain;

import java.util.Date;
import java.util.List;

/**
 * Factura
 *
 */
public class Factura {

	private List<Visualizacion> visualizaciones;
	private Usuario usuario;
	private Date fecha;

	/**
	 * Constructor
	 * @param visualizaciones
	 * @param usuario
	 * @param fecha
	 */
	public Factura(List<Visualizacion> visualizaciones, Usuario usuario, Date fecha) {
		this.visualizaciones = visualizaciones;
		this.usuario = usuario;
		this.fecha = fecha;
	}

	/* Getters y Setters  */

	public List<Visualizacion> getVisualizaciones() {
		return visualizaciones;
	}

	public void setVisualizaciones(List<Visualizacion> visualizaciones) {
		this.visualizaciones = visualizaciones;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	/**
	 * Metodo para anadir un cargo (visualizacion) a la factura
	 * @param v
	 */
	public void anadirCargo(Visualizacion v){
		visualizaciones.add(v);
	}

}
