package es.unican.docencia.y2011.eda.herenciaMultiple.particulas;

/**
 * Clase que sirve para lanzar el programa de demostración del
 * funcionamiento de la herencia múltiple en Java mediante el 
 * uso de interfaces y mixins (version particulas)
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * 		   http://personales.unican.es/sanchezbp	
  */
public class Runner {

	/**
	 * Metodo de entrada a la aplicacion
	 * @param args Argumentos de la linea de comandos. Son simplemente ignorados
	 */
	public static void main(String[] args) {
		
		// Creamos dos electrones
		Electron e1 = new Electron();
		Electron e2 = new Electron();
		
		// Los movemos un poco en el espacio para que no esten en el mismo punto
		e1.mover(100, 100);
		e2.mover(-50,-100);
		
		// Calculamos la fuerza de atraccion
		double fuerza = e1.atraccion(e2);
		
		// y la imprimimos
		System.out.println("La fuerza a atraccion entre los electrones es de " + fuerza + " Newtons");
		
	} // main
} // Runnner
