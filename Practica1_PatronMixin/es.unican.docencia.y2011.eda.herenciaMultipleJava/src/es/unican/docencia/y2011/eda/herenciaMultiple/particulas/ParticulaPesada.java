package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase representado a una particula pesada
 * @author Pablo Sánchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public class ParticulaPesada implements IPunto, IParticulaPesada {

	// Realizamos la herencia de comportamiento a mano
	// mediante la inscrustación de un objeto que implementa
	// la interfaz de la cual extendemos
	protected Punto mixedPunto = null;
	// Masa de la particula
	protected double masa = 0.0;
	
	protected static final double G = 6.67428E-11; 
	
	/**
	 * Constructor por defecto de la clase ParticulaPesada
	 * Inicializa las coordenadas a (0.0) y la partícula no 
	 * tiene masa
	 */
	public ParticulaPesada() {
		mixedPunto = new Punto();
	} // ParticulaPesada
	
	//--------------------------------------------------------------------------//
	// Para las operaciones que debemos implementar de la interfaz, simplemente //
	// delegamos sobre la clase que ejerce de mixin.                            //
	// Si lo analizamos detenidamente, esto no es más que una tabla de          //  
	// vinculación dinámica implementada directamente en Java					//   
	//--------------------------------------------------------------------------//	
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#getX()
	 */
	@Override
	public double getX() {
		return mixedPunto.getX();
	} // getX

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#getY()
	 */
	@Override
	public double getY() {
		return mixedPunto.getY();
	} // getY
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#setX(double)
	 */
	@Override
	public void setX(double x) {
		mixedPunto.setX(x);
	} // setX

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#setY(double)
	 */
	@Override
	public void setY(double y) {
		mixedPunto.setY(y);
	} // setY

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#mover(int, int)
	 */
	@Override
	public void mover(int deltaX, int deltaY) {
		mixedPunto.mover(deltaX,deltaY);
	} // mover
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#distancia(es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto)
	 */
	@Override
	public double distancia(IPunto punto) {
		return mixedPunto.distancia(punto);
	} // distancia

	//--------------------------------------------------------------------------//
	// Implementamos aquí los metodos propios de ParticulaPesada, es decir      //
	// aquellos que no son "heredados" de Punto.							    // 
	//--------------------------------------------------------------------------//	

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaPesada#getMasa()
	 */
	public double getMasa() {
		return masa;
	} // getMasa

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaPesada#setMasa()
	 */
	public void setMasa(double masa) {
		this.masa = masa;
	} // setMasa
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaPesada#atraccion(IParticulaPesada)
	 */
	public double atraccion(IParticulaPesada particula) {
		return ParticulaPesada.G*((this.getMasa()*particula.getMasa())/(this.distancia(particula)));
	} // atraccion
		
} // ParticulaPesada
