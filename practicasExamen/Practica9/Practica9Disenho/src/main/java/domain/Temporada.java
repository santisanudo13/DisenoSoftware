package domain;

import java.util.ArrayList;
import java.util.List;

/**
 * Temporada
 *
 */
public class Temporada {

	private long idTemporada;
	private int numTemporada;
	private Serie serie;
	private List<Capitulo> capitulos;

	/**
	 * Constructor
	 * @param numTemporada
	 * @param serie
	 */
	public Temporada(int numTemporada, Serie serie) {
		this.numTemporada = numTemporada;
		this.serie = serie;
		this.capitulos = new ArrayList<Capitulo>();
	}

	/* Getters y Setters  */

	public int getNumTemporada() {
		return numTemporada;
	}

	public void setNumTemporada(int numTemporada) {
		this.numTemporada = numTemporada;
	}

	public List<Capitulo> getCapitulos() {
		return capitulos;
	}

	public void setCapitulos(List<Capitulo> capitulos) {
		this.capitulos = capitulos;
	}

	public Serie getSerie() {
		return serie;
	}

	public void setSerie(Serie serie) {
		this.serie = serie;
	}

	public long getIdTemporada() {
		return idTemporada;
	}

	public void setIdTemporada(long idTemporada) {
		this.idTemporada = idTemporada;
	}

	/**
	 * Metodo toString
	 */
	@Override
	public String toString() {
		return "Temporada [idTemporada=" + idTemporada + ", numTemporada=" + numTemporada + ", serie=" + serie
				+ ", capitulos=" + capitulos + "]";
	}

}
