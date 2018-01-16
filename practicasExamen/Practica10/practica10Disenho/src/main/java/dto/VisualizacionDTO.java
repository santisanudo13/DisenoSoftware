package dto;

import java.util.Date;

/**
 * DTO para las visualizaciones
 *
 */
public class VisualizacionDTO {

	private long idUsuario;
	private String nombreSerie;
	private String capitulo;
	private String precio;
	private Date fecha;

	/**
	 * Constructor
	 * @param idUsuario
	 * @param nombreSerie
	 * @param capitulo
	 * @param precio
	 * @param fecha
	 */
	public VisualizacionDTO(long idUsuario,String nombreSerie, String capitulo, String precio, Date fecha) {
		this.idUsuario = idUsuario;
		this.nombreSerie = nombreSerie;
		this.capitulo = capitulo;
		this.precio = precio;
		this.fecha = fecha;
	}

	/* GETTERS Y SETTERS */

	public String getNombreSerie() {
		return nombreSerie;
	}

	public void setNombreSerie(String nombreSerie) {
		this.nombreSerie = nombreSerie;
	}

	public String getCapitulo() {
		return capitulo;
	}

	public void setCapitulo(String capitulo) {
		this.capitulo = capitulo;
	}

	public String getPrecio() {
		return precio;
	}

	public void setPrecio(String precio) {
		this.precio = precio;
	}

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public long getIdUsuario() {
		return idUsuario;
	}

	public void setIdUsuario(long idUsuario) {
		this.idUsuario = idUsuario;
	}

}
