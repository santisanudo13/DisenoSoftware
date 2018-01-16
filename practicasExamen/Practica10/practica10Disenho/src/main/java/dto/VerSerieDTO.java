package dto;

import java.util.List;

/**
 * DTO de la interfaz VerSerie
 *
 */
public class VerSerieDTO {

	private String nombreSerie;
	private String tipoSerie;
	private List<TemporadaDTO> temporadas;
	
	public VerSerieDTO(String nombreSerie, String tipoSerie, List<TemporadaDTO> temporadas) {
		this.nombreSerie = nombreSerie;
		this.tipoSerie = tipoSerie;
		this.temporadas = temporadas;
	}
	
	/* GETTERS Y SETTERS */

	public String getNombreSerie() {
		return nombreSerie;
	}

	public void setNombreSerie(String nombreSerie) {
		this.nombreSerie = nombreSerie;
	}

	public String getTipoSerie() {
		return tipoSerie;
	}

	public void setTipoSerie(String tipoSerie) {
		this.tipoSerie = tipoSerie;
	}

	public List<TemporadaDTO> getTemporadas() {
		return temporadas;
	}

	public void setTemporadas(List<TemporadaDTO> temporadas) {
		this.temporadas = temporadas;
	}
			
}
