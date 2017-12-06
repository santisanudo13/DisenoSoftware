package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Interfaz de la clase representando un punto en el plano
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public interface IPunto {

	/** 
	 * Devuelve el valor de la coordenada X
	 * @return La abscisa del punto
	 */
	public double getX(); 

	/** 
	 * Asigna el valor de la abscisa X
	 * @param x El valor a ser asignado a la abscisa   
	 */
	public void setX(double x); 

	/** 
	 * Devuelve el valor de la coordenada Y
	 * @return La coordenada del punto
	 */
	public double getY(); 

	/** 
	 * Asigna el valor de la ordenada Y
	 * @param x El valor a ser asignado a la ordenada 
	 */
	public void setY(double y); 

	/**
	 * Desplaza un punto la cantidad horizontal especificada por 
	 * deltaX y la cantidad vertical especificada por deltaY
	 * @param deltaX Desplazamiento Horizontal
	 * @param deltaY Desplazamiento Vertical
	 */
	public void mover(int deltaX, int deltaY);
	
	/**
	 * Devuelve la distancia euclidea entre el punto actual y 
	 * el punto que se pasa como parametro   
	 * @param punto El punto que dista del nuestro
	 * @return La distancia del punto actual a punto.
	 */
	public double distancia(IPunto punto);

} // IPunto