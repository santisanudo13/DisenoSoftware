package dto;

import java.util.List;

/**
 * DTO para las termporadas
 *
 */
public class TemporadaDTO {
	
	private int numTemporada;
	private List<CapituloDTO> capitulos;
	
	/**
	 * Constructor
	 * @param numTemporada
	 * @param capitulos
	 */
	public TemporadaDTO(int numTemporada, List<CapituloDTO> capitulos) {
		super();
		this.numTemporada = numTemporada;
		this.capitulos = capitulos;
	}

	/* GETTERS Y SETTERS */
	
	public int getNumTemporada() {
		return numTemporada;
	}

	public void setNumTemporada(int numTemporada) {
		this.numTemporada = numTemporada;
	}

	public List<CapituloDTO> getCapitulos() {
		return capitulos;
	}

	public void setCapitulos(List<CapituloDTO> capitulos) {
		this.capitulos = capitulos;
	}
	
}
