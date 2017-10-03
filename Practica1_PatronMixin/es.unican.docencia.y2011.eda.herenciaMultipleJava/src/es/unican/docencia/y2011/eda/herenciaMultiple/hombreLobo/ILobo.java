package es.unican.docencia.y2011.eda.herenciaMultiple.hombreLobo;

/**
 * Interfaz que define las acciones que puede ejecutar un lobo
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * 		   http://personales.unican.es/sanchezbp	
 */
public interface ILobo {

	/**
	 * Devuelve el nombre de un lobo
	 * @return El nombre del lobo 
	 */
	public String getName(); 

	/**
	 * Asigna el nombre pasado como parámetro al lobo
	 * @param name Nombre con el cual se bautiza al lobo
	 */
	public void setName(String name); 

	/**
	 * El lobo aulla para decir hola
	 */
	public void saluda(); 

	/**
	 * Al hombre lobo siempre le puede su instinto caníbal, y al final se come al 
	 * que sea si se lo pedimos
	 * @param h El hombre a ser devorado por el hombre lobo  
	 */
	public void despedaza(Hombre h);

} // ILobo