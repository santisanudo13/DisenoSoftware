package es.unican.docencia.y2011.eda.herenciaMultiple.hombreLobo;

/**
 * Clase que representa a un licántropo, es decir a un hombre lobo
 * @author Pablo Sanchez (p.sanchez@unican.es)
 * http://personales.unican.es/sanchezbp
 */
public class HombreLobo extends Hombre implements ILobo {
	
	// Objeto sobre el que voy a delegar las operaciones concernientes 
	// a los lobos
	protected ILobo mixedLobo = new Lobo();
	protected boolean lunaLLena = false;
	
	/**
	 * Metodo observador del atributo luna llena, que afecta al comportamiento
	 * del licantropo
	 * @return Verdadero si es luna llena, falso en caso contrario
	 */
	public boolean isLunaLLena() {
		return lunaLLena;
	} // isLunaLLena

	/**
	 * Metodo modificador del atributo luna llena, que afecta al comportamiento
	 * del licantropo
	 * @param esLunaLLena Valor a ser asignado al atributo luna llena 
	 */
	public void setEsLunaLLena(boolean lunaLLena) {
		this.lunaLLena = lunaLLena;
	} // setLunaLLena

	/**
	 * @see es.unican.docencia.y2011.eda.herenciaMultiple.hombreLobo.ILobo#despedaza()
	 */
	public void despedaza(Hombre h) {
		mixedLobo.despedaza(h);
	} // despederaza
	
	/**
	 * Asignarle a un hombrelobo su nombre de lobo 
	 * @param name su nombre de hombre lobo
	 */
	public void setLoboName(String name) {
		mixedLobo.setName(name);
	} // setLoboName

	/**
	 * Devuelve el nombre de un hombre lobo en su faceta de lobo 
	 * @returns el nombre de un hombre lobo en su faceta de lobo
	 */
	public String getLoboName(String name) {
		return mixedLobo.getName();
	} // setLoboName

	/**
	 * Sobreescribimos el metodo saluada para el hombre lobo. 
	 * En caso de que sea un dia de luna llena, el hombre lobo esta en modo lobo
	 * y aulla. En caso contrario, se comporta como una persona y saluda de forma
	 * educada 
	 * @see es.unican.docencia.y2011.eda.herenciaMultipleJava.Hombre#saluda()
	 */
	@Override
	public void saluda() {
		if (lunaLLena) {
			mixedLobo.saluda();
		} else {
			super.saluda();
		} // if 	
	} // saluda
	
} // HombreLobo
