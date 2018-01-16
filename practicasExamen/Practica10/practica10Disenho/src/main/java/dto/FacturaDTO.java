package dto;

import java.util.List;

/**
 * DTO para la interfaz Ver Cargos
 *
 */
public class FacturaDTO {

	private String mes;
	private int anyo;
	private List<VisualizacionDTO> visualizaciones;
	
	/**
	 * Constructor
	 * @param mes
	 * @param anyo
	 * @param visualizaciones
	 */
	public FacturaDTO(String mes, int anyo, List<VisualizacionDTO> visualizaciones) {
		this.mes = mes;
		this.anyo = anyo;
		this.visualizaciones = visualizaciones;
	}

	/* GETTERS Y SETTERS */
	
	public String getMes() {
		return mes;
	}

	public void setMes(String mes) {
		this.mes = mes;
	}

	public int getAnyo() {
		return anyo;
	}

	public void setAnyo(int anyo) {
		this.anyo = anyo;
	}

	public List<VisualizacionDTO> getVisualizaciones() {
		return visualizaciones;
	}

	public void setVisualizaciones(List<VisualizacionDTO> visualizaciones) {
		this.visualizaciones = visualizaciones;
	}
		
}
