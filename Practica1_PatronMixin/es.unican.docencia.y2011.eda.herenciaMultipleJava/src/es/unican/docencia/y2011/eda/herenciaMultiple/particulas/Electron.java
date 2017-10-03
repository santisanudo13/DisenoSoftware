package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase representando un electron  
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public class Electron extends ParticulaCargada implements IParticulaCargada, IParticulaPesada {

	// Mixins ParticulaPesada
	protected ParticulaPesada mixinPesada = null;
	
	// Definimos como contantes la masa y carga de un electron
	protected static final double MASA  = 9.10938215E-31; 
	protected static final double CARGA = -1.602176487E10-19; 		
	
	/**
	 * Constructor vacio para la clase electron, que se situaria en el punto (0,0), 
	 * a la masa le asignaríamos la masa del electron y a la carga la carga del electron
	 * La masa hay que asignarla a través del mixin
	 */
	public Electron() {
		mixinPesada = new ParticulaPesada();
		this.carga  = CARGA;
		mixinPesada.setMasa(MASA);
	} // Electron

	//--------------------------------------------------------------------------//
	// Para las operaciones que debemos implementar de la interfaz, simplemente //
	// delegamos sobre la clase que ejerce de mixin.                            //
	// Si lo analizamos detenidamente, esto no es más que una tabla de          //  
	// vinculación dinámica implementada directamente en Java					//   
	//--------------------------------------------------------------------------//	

	/**
	 * @return
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.ParticulaPesada#getMasa()
	 */
	public double getMasa() {
		return mixinPesada.getMasa();
	} //getMasa

	/**
	 * La masa de un electron es inmutable (salvo consideraciones relativistas), 
	 * por lo que este metodo no tiene ningún efecto 
	 * @param masa Masa que *no* va a ser asignada
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.ParticulaPesada#setMasa(double)
	 */
	public void setMasa(double masa) {		
	} //setMasa

	/**
	 * Atraccion gravitatoria entre nuestro electron y el electron pasado como parametro
	 * @param particula Electro que atrae gravitatoriamente al nuestro
	 * @return Fuerza de atraccion gravitatoria entre los electrones
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.ParticulaPesada#atraccion(es.unican.docencia.y2011.eda.herenciaMultiple.particulas.IParticulaPesada)
	 */
	public double atraccion(IParticulaPesada particula) {
		return mixinPesada.atraccion(particula);
	} // atraccion (gravitatoria)

	//---------------------------------------------------------------------------//
	// Redefinimos ciertos metodos para que el electron se comporte de manera    //
	// adecuada																     //
	//---------------------------------------------------------------------------//

	/**
	 * La carga de un electron es inmutable (salvo consideraciones extras), 
	 * por lo que este metodo no tiene ningún efecto 
	 * @param carga Carga que *no* va a ser asignada
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.particulas.ParticulaCargada#setCarga(double)
	 */
	@Override
	public void setCarga(double carga) {
	} // setCarga
	
	//---------------------------------------------------------------------------//
	// Anhadimos un metodo con un nuevo perfil que se encarga de calcular la     //
	// atraccion (gravitatoria más electrica) entre dos electrones			     //
	//---------------------------------------------------------------------------//	
	
	/**
	 * Calcula la atraccion (gravitatoria + electrica)entre dos electrones
	 * @param electron El otra electro que atrae a nuestro electron
	 * 		   Pre: (this.distancia(electron) > 0) (Es decir, 
	 * 				 los electrones no pueden estar en el mismo punto)	
	 * @return La fuerza de atraccion entre dichos electrones
	 */
	public double atraccion(Electron electron) {
		return super.atraccion(electron)+mixinPesada.atraccion(electron);
	} // atraccion
	
} // Electron
