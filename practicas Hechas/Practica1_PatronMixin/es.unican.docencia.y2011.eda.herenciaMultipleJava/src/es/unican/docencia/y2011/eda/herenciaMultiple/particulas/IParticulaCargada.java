package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase representado a una particula cargada
 * @author Pablo Sánchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public interface IParticulaCargada extends IPunto {

	/**
	 * Devuelve la carga de la particula cargada
	 * @return La carga de la particula cargada
	 */
	public double getCarga(); 

	/**
	 * Asigna un valor de carga a la particula cargada
	 * @param carga La carga a ser asignada
	 */
	public void setCarga(double carga); 

	/**
	 * Calcula la atracción gravitatoria entre dos particulas pesadas
	 * @param particula La otra particula que atrae a nuestra particula
	 * 		   Pre: (this.distancia(particula) > 0) (Es decir, 
	 * 				 las particulas no pueden estar en el mismo punto)	
	 * @return La fuerza de atraccion entre dichas particulas
	 * 		   Post: Si la fuerza es de atraccion (cargas del mismo signo)
	 * 				 el valor de la fuerza sera positivo. Si la fuerza es 
	 * 				 de repulsion, el valor de la fuerza sera negativo  	
	 */
	public double atraccion(IParticulaCargada particula); 

} // IParticulaCargada