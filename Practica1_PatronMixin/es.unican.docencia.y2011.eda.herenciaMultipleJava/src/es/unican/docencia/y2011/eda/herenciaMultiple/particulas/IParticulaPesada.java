package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase representado a una particula pesada
 * @author Pablo Sánchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public interface IParticulaPesada extends IPunto {

	/**
	 * Devuelve la masa de la particula pesada
	 * @return La masa de la particula pesada
	 */
	public double getMasa(); 

	/**
	 * Asigna un valor de masa a la particula pesada
	 * @param masa La masa a ser asignada
	 * 		  Pre: masa >= 0.0	
	 */
	public void setMasa(double masa); 

	/**
	 * Calcula la atracción gravitatoria entre dos particulas pesadas
	 * @param particula La otra particula que atrae a nuestra particula
	 * 		   Pre: (this.distancia(particula) > 0) (Es decir, 
	 * 				 las particulas no pueden estar en el mismo punto)	
	 * @return La fuerza de atraccion entre dichas particulas
	 */
	public double atraccion(IParticulaPesada particula); 

} // IParticulaPesada