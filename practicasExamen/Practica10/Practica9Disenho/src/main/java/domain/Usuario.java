package domain;

import java.util.List;

/**
 * Usuario
 *
 */
public class Usuario {

	private long id;

	private String nombreUsuario;
	private String password;
	private String cuentaISBAN;

	private Cuota cuota;
	
	private List<Factura> facturas;
	private List<Visualizacion> visualizaciones;
	private List<Serie> seriesPendientes;
	private List<Serie> seriesComenzadas;
	private List<Serie> seriesTerminadas;

	/**
	 * Constructor
	 * @param nombreUsuario
	 * @param password
	 * @param cuentaISBAN
	 */
	public Usuario(String nombreUsuario, String password, String cuentaISBAN) {
		this.nombreUsuario = nombreUsuario;
		this.password = password;
		this.cuentaISBAN = cuentaISBAN;
	}

	/* Getters y Setters  */

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getNombreUsuario() {
		return nombreUsuario;
	}

	public void setNombreUsuario(String nombreUsuario) {
		this.nombreUsuario = nombreUsuario;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getCuentaISBAN() {
		return cuentaISBAN;
	}

	public void setCuentaISBAN(String cuentaISBAN) {
		this.cuentaISBAN = cuentaISBAN;
	}

	public List<Visualizacion> getVisualizaciones() {
		return visualizaciones;
	}

	public List<Serie> getSeriesPendientes() {
		return seriesPendientes;
	}

	public List<Serie> getSeriesComenzadas() {
		return seriesComenzadas;
	}

	public List<Serie> getSeriesTerminadas() {
		return seriesTerminadas;
	}

	public List<Factura> getFacturas() {
		return facturas;
	}

	public void setFacturas(List<Factura> facturas) {
		this.facturas = facturas;
	}

	public void setVisualizaciones(List<Visualizacion> visualizaciones) {
		this.visualizaciones = visualizaciones;
	}

	public void setSeriesPendientes(List<Serie> seriesPendientes) {
		this.seriesPendientes = seriesPendientes;
	}

	public void setSeriesComenzadas(List<Serie> seriesComenzadas) {
		this.seriesComenzadas = seriesComenzadas;
	}

	public void setSeriesTerminadas(List<Serie> seriesTerminadas) {
		this.seriesTerminadas = seriesTerminadas;
	}

	public Cuota getCuota() {
		return cuota;
	}

	public void setCuota(Cuota cuota) {
		this.cuota = cuota;
	}

}
