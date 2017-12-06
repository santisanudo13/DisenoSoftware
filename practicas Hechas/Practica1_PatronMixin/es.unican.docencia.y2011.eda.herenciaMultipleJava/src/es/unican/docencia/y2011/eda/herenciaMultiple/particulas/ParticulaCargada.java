package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase representado a una particula cargada
 * @author Pablo Sánchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public class ParticulaCargada implements IPunto, IParticulaCargada  {

	// Realizamos la herencia de comportamiento a mano
	// mediante la inscrustación de un objeto que implementa
	// la interfaz de la cual extendemos
	protected Punto mixedPunto = new Punto();
	// Carga de la particula. El signo del valor indica el signo 
	// de la carga
	protected double carga = 0.0;
	
	// Constante de Coulomb más usual
	protected static final double K = 8.987551787E9;  
	
	//--------------------------------------------------------------------------//
	// Para las operaciones que debemos implementar de la interfaz, simplemente //
	// delegamos sobre la clase que ejerce de mixin.                            //
	// Si lo analizamos detenidamente, esto no es más que una tabla de          //  
	// vinculación dinámica implementada directamente en Java					//   
	//--------------------------------------------------------------------------//	

	/**
	 * @param punto
	 * @return
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.Punto#distancia(es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto)
	 */
	public double distancia(IPunto punto) {
		return mixedPunto.distancia(punto);
	} // distancia

	/**
	 * @return
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.Punto#getX()
	 */
	public double getX() {
		return mixedPunto.getX();
	} // getX

	/**
	 * @return
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.Punto#getY()
	 */
	public double getY() {
		return mixedPunto.getY();
	} // getY

	/**
	 * @param deltaX
	 * @param deltaY
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.Punto#mover(int, int)
	 */
	public void mover(int deltaX, int deltaY) {
		mixedPunto.mover(deltaX, deltaY);
	} // mover

	/**
	 * @param x
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.Punto#setX(double)
	 */
	public void setX(double x) {
		mixedPunto.setX(x);
	} // setX

	/**
	 * @param y
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.Punto#setY(double)
	 */
	public void setY(double y) {
		mixedPunto.setY(y);
	} // setY
		
	//--------------------------------------------------------------------------//
	// Implementamos aquí los metodos propios de ParticulaCargada, es decir     //
	// aquellos que no son "heredados" de Punto.							    // 
	//--------------------------------------------------------------------------//	

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaCargada#getCarga()
	 */
	public double getCarga(){
		return this.carga;
	} //getCarga
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaCargada#setCarga(double)
	 */
	public void setCarga(double carga) {
		this.carga = carga;
	} //setMasa

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaCargada#atraccion(IParticulaCargada)
	 */
	public double atraccion(IParticulaCargada particula){
		return ParticulaCargada.K*((this.getCarga()*particula.getCarga())/(this.distancia(particula)));
	} // atraccion
	
} // ParticulaCargada
