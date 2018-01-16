package dto;


/**
 * DTO para los capitulos
 *
 */
public class CapituloDTO {

	private String titulo;
	private int numCapitulo;
	private String enlace;
	private boolean visto;
	
	/**
	 * Constructor
	 * @param titulo
	 * @param numCapitulo
	 * @param enlace
	 * @param visto
	 */
	public CapituloDTO(String titulo, int numCapitulo, String enlace, boolean visto) {
		this.titulo = titulo;
		this.numCapitulo = numCapitulo;
		this.enlace = enlace;
		this.visto = visto;
	}

	/* GETTERS Y SETTERS */
	
	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public int getNumCapitulo() {
		return numCapitulo;
	}

	public void setNumCapitulo(int numCapitulo) {
		this.numCapitulo = numCapitulo;
	}

	public String getEnlace() {
		return enlace;
	}

	public void setEnlace(String enlace) {
		this.enlace = enlace;
	}

	public boolean isVisto() {
		return visto;
	}

	public void setVisto(boolean visto) {
		this.visto = visto;
	}
		
}
