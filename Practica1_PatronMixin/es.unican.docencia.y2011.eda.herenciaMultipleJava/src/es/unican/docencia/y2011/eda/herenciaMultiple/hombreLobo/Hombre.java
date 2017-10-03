package es.unican.docencia.y2011.eda.herenciaMultiple.hombreLobo;

/**
 * Clase que representa a un ser humano 
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * 		   http://personales.unican.es/sanchezbp 
 */
public class Hombre {
	
	// Nombre del ser humano
	protected String name = null;
	
	/**
	 * Método observador para el atributo name (nombre)
	 * @return el nombre del ser humano
	 */
	public String getName() {
		return name;
	} // getName

	/**
	 * Método modificador para el atributo name (nombre)
	 * @param name Nombre para bautizar al ser humano
	 */
	public void setName(String name) {
		this.name = name;
	} // setName
	
	/**
	 * El ser humano se presenta de forma educada. El saludo se imprime por consola.
	 */
	public void saluda() {
		System.out.println("Hola, soy " + this.name + ", encantado de conocerle" );
	} // saluda

} // Hombre
