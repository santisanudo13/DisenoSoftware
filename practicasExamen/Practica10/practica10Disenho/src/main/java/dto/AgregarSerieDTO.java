package dto;

import java.util.List;

/**
 * DTO para la interfaz AgregarSerie
 *
 */
public class AgregarSerieDTO {

	private long id;
	private String nombreSerie;
	private String tipoSerie;
	private String sinopsis;
	private String creador;
	private List<String> artistas;
	
	/**
	 * Constructor
	 * @param nombreSerie
	 * @param tipoSerie
	 * @param sinopsis
	 * @param creador
	 * @param artistas
	 */
	public AgregarSerieDTO(String nombreSerie, String tipoSerie, String sinopsis, String creador, List<String> artistas) {
		super();
		this.nombreSerie = nombreSerie;
		this.tipoSerie = tipoSerie;
		this.sinopsis = sinopsis;
		this.creador = creador;
		this.artistas = artistas;
	}

	/* GETTERS Y SETTERS */
	
	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getNombreSerie() {
		return nombreSerie;
	}

	public void setNombreSerie(String nombreSerie) {
		this.nombreSerie = nombreSerie;
	}

	public String getSinopsis() {
		return sinopsis;
	}

	public void setSinopsis(String sinopsis) {
		this.sinopsis = sinopsis;
	}

	public String getCreador() {
		return creador;
	}

	public void setCreador(String creador) {
		this.creador = creador;
	}

	public List<String> getArtistas() {
		return artistas;
	}

	public void setArtistas(List<String> artistas) {
		this.artistas = artistas;
	}

	public String getTipoSerie() {
		return tipoSerie;
	}

	public void setTipoSerie(String tipoSerie) {
		this.tipoSerie = tipoSerie;
	}
			
}
