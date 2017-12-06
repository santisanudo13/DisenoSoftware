package es.unican.docencia.y2011.eda.herenciaMultiple.hombreLobo;

/**
 * Clase que sirve para lanzar el programa de demostración del
 * funcionamiento de la herencia múltiple en Java mediante el 
 * uso de interfaces y mixins (version licantropos)
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * 		   http://personales.unican.es/sanchezbp	
  */
public class Runner {

	/**
	 * Metodo de entrada a la aplicacion
	 * @param args Argumentos de la linea de comandos. Son simplemente ignorados
	 */
	public static void main(String[] args) {
		
		// Creamos un hombre y un hombre lobo.
		HombreLobo teenWolf = new HombreLobo();
		Hombre ramoncin = new Hombre();
		
		// Bautizamos a nuestra poblacion 
		ramoncin.setName("El Rey del Pollo Frito");
		// A teen wolf le podemos asignar su nombre de lobo y su nombre de persona
		// Su nombre por defecto es su nombre de persona 
		teenWolf.setName("Scott");
		teenWolf.setLoboName("Teen Wolf");
		
		// Nuestra población se presenta en un dia no de luna llena
		teenWolf.setEsLunaLLena(false);
		System.out.println(" Hoy no es un dia de luna llena ");
		System.out.println("--------------------------------");
		ramoncin.saluda();
		teenWolf.saluda();
		
		// Nuestra población se presenta en un dia de luna llena
		teenWolf.setEsLunaLLena(true);
		System.out.println("");
		System.out.println(" Hoy si es un dia de luna llena ");
		System.out.println("--------------------------------");
		ramoncin.saluda();
		teenWolf.saluda();
		
		// Le damos la orden a teen wolf de comerse a ramoncin
		System.out.println("");		
		teenWolf.despedaza(ramoncin);

	} // main
} // Runnner
