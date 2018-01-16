package dto;

import java.util.List;

/**
 * DTO para la interfaz Pagina Personal del Usuario
 *
 */
public class PaginaPrincipalDTO {
	
	private List<String> seriesEmpezadas;
	private List<String> seriesPendientes;
	private List<String> seriesTerminadas;
	
	/**
	 * Constructor
	 * @param seriesEmpezadas
	 * @param seriesPendientes
	 * @param seriesTerminadas
	 */
	public PaginaPrincipalDTO(List<String> seriesEmpezadas, List<String> seriesPendientes,
			List<String> seriesTerminadas) {
		this.seriesEmpezadas = seriesEmpezadas;
		this.seriesPendientes = seriesPendientes;
		this.seriesTerminadas = seriesTerminadas;
	}
	
	/* GETTERS Y SETTERS */
	
	public List<String> getSeriesEmpezadas() {
		return seriesEmpezadas;
	}
	
	public void setSeriesEmpezadas(List<String> seriesEmpezadas) {
		this.seriesEmpezadas = seriesEmpezadas;
	}
	
	public List<String> getSeriesPendientes() {
		return seriesPendientes;
	}
	
	public void setSeriesPendientes(List<String> seriesPendientes) {
		this.seriesPendientes = seriesPendientes;
	}
	
	public List<String> getSeriesTerminadas() {
		return seriesTerminadas;
	}
	
	public void setSeriesTerminadas(List<String> seriesTerminadas) {
		this.seriesTerminadas = seriesTerminadas;
	}
	
}
