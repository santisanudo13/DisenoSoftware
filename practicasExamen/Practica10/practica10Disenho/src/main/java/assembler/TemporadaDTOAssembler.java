package assembler;

import java.util.LinkedList;
import java.util.List;

import domain.*;
import dto.*;

/**
 * Assembler para la creacion del DTO VerSerie
 *
 */
public class TemporadaDTOAssembler {

	private static TemporadaDTOAssembler temporadaAssembler;

	private TemporadaDTOAssembler(){}

	/**
	 * Singleton
	 * @return instancia unica del assembler
	 */
	public static TemporadaDTOAssembler getInstance(){
		if(temporadaAssembler==null){
			temporadaAssembler = new TemporadaDTOAssembler();
		}
		return temporadaAssembler;
	}

	/**
	 * Metodo para obtener el DTO de las temporadas de la interfaz VerSerie
	 * @param t
	 * @param u
	 * @return DTO de la temporada
	 */
	public TemporadaDTO getTemporada(Temporada t, Usuario u){
		
		int numTemporada = t.getNumTemporada();

		List<CapituloDTO> capitulos = new LinkedList<CapituloDTO>();

		CapituloDTO capituloDTO;
		
		CapituloDTOAssembler capituloAssembler = CapituloDTOAssembler.getInstance();
		
		for(Capitulo c:t.getCapitulos()){
			capituloDTO = capituloAssembler.getCapitulo(c,u);
			capitulos.add(capituloDTO);
		}

		return new TemporadaDTO(numTemporada, capitulos);
	
	}
	
}
