package es.unican.docencia.y2011.eda.herenciaMultiple.hombreLobo;

public class Lobo implements ILobo {
	
	// Nombre del lobo
	protected String name = null;
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultipleJava.ILobo#getName()
	 */
	public String getName() {
		return name;
	} // getName

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultipleJava.ILobo#setName(java.lang.String)
	 */
	public void setName(String name) {
		this.name = name;
	} // setName
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultipleJava.ILobo#saluda()
	 */
	public void saluda() {
		System.out.println("Auuuuuuuuuuuuuuuu" );
	} // saluda

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultipleJava.ILobo#despederaza()
	 */
	public void despedaza(Hombre h) {
		System.out.println("Soy " + name + " y me estoy comiendo a " + h.getName());
	} // despedaza

} // Lobo
