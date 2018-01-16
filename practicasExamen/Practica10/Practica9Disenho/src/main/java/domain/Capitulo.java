package domain;

/**
 * Capitulo
 *
 */
public class Capitulo {

	private long idCapitulo;
	private int numCapitulo;
	private String titulo;
	private String enlace;

	private Temporada temporada;

	/**
	 * Constructor
	 * @param numCapitulo
	 * @param titulo
	 * @param enlace
	 * @param temporada
	 */
	public Capitulo(int numCapitulo, String titulo, String enlace, Temporada temporada) {
		super();
		this.numCapitulo = numCapitulo;
		this.titulo = titulo;
		this.enlace = enlace;
		this.temporada = temporada;
	}

	/* Getters y Setters  */

	public int getNumCapitulo() {
		return numCapitulo;
	}

	public void setNumCapitulo(int numCapitulo) {
		this.numCapitulo = numCapitulo;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public String getEnlace() {
		return enlace;
	}

	public void setEnlace(String enlace) {
		this.enlace = enlace;
	}

	public Temporada getTemporada() {
		return temporada;
	}

	public void setTemporada(Temporada temporada) {
		this.temporada = temporada;
	}

	public long getIdCapitulo() {
		return idCapitulo;
	}

	public void setIdCapitulo(long idCapitulo) {
		this.idCapitulo = idCapitulo;
	}

}
