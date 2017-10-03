package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase representando un punto en el plano 
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public class Punto implements IPunto {
	
	protected double x = 0.0;
	protected double y = 0.0;
	
	/**
	 * Constructor por defecto para la clase Punto
	 * Inicializa las coordenadas a (0,0)
	 */
	public Punto() {
		
	} // Punto
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#getX()
	 */
	public double getX() {
		return x;
	} // getX
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#setX(double)
	 */
	public void setX(double x) {
		this.x = x;
	} // setX
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#getY()
	 */	public double getY() {
		return y;
	} // getY

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#setY(double)
	 */
	public void setY(double y) {
		this.y = y;
	} // setY
	
	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#mover(int, int)
	 */
	public void mover(int deltaX, int deltaY) {
		this.setX(this.getX()+deltaX);
		this.setY(this.getY()+deltaY);
	} // mover

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto#distancia(es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IPunto)
	 */
	@Override
	public double distancia(IPunto punto) {
		double difX = this.getX() - punto.getX();
		double difY = this.getY() - punto.getY();
		return Math.sqrt((difX*difX)+(difY*difY));
	} // distancia
		
} // Punto
