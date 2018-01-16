package extra;

import domain.*;
import dto.*;

/**
 * Assembler para la creacion del DTO VerSerie
 *
 */
public class CapituloDTOAssembler {

	private static CapituloDTOAssembler capituloAssembler;

	private CapituloDTOAssembler(){}

	/**
	 * Singleton
	 * @return instancia unica del assembler
	 */
	public static CapituloDTOAssembler getInstance(){
		if(capituloAssembler==null){
			capituloAssembler = new CapituloDTOAssembler();
		}
		return capituloAssembler;
	}

	/**
	 * Metodo para obtener el DTO de los capitulos para la interfaz VerSerie
	 * @param c
	 * @param u
	 * @return dto del capitulo
	 */
	public CapituloDTO getCapitulo(Capitulo c, Usuario u){

		String titulo = c.getTitulo();
		int numCapitulo = c.getNumCapitulo();
		String enlace = c.getEnlace();

		Capitulo capitulo;
		boolean visto = false;
		
		for(Visualizacion v:u.getVisualizaciones()){
			capitulo = v.getCapitulo();
			if(capitulo.equals(c)){
				visto = true;
			}
		}		

		return new CapituloDTO(titulo, numCapitulo, enlace, visto);

	}

}
