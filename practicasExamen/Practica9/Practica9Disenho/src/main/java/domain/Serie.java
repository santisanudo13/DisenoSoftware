package domain;

import java.util.List;

import p8.excepciones.*;

/**
 * Serie abstracta
 *
 */
public abstract class Serie {

	private long id;
	private String nombre;
	private String sinopsis;

	protected List<Temporada> temporadas;
	protected List<Artista> artistas;
	protected Creador creador;

	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public Serie(String nombre, String sinopsis) {
		this.nombre = nombre;
		this.sinopsis = sinopsis;
	}

	/* Getters y Setters  */

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getSinopsis() {
		return sinopsis;
	}

	public void setSinopsis(String sinopsis) {
		this.sinopsis = sinopsis;
	}

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public abstract Creador getCreador() throws NoSeHaPodidoConectarABBDD;

	public abstract List<Artista> getArtistas() throws NoSeHaPodidoConectarABBDD;

	public abstract List<Temporada> getTemporadas() throws NoSeHaPodidoConectarABBDD;

	public void setCreador(Creador creador) {
		this.creador = creador;
	}

	public void setTemporadas(List<Temporada> temporadas) {
		this.temporadas = temporadas;
	}

	public void setArtistas(List<Artista> artistas) {
		this.artistas = artistas;
	}

	/**
	 * Metodo toString
	 */
	public String toString() {
		return "Serie [id=" + id + ", nombre=" + nombre +  ", sinopsis=" + sinopsis + "]";
	}

}
