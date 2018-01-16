package assembler;

import java.util.LinkedList;
import java.util.List;

import domain.*;
import dto.*;
import p8.excepciones.NoSeHaPodidoConectarABBDD;
import proxy.*;

/**
 * Assembler para la creacion del DTO VerSerie
 *
 */
public class VerSerieDTOAssembler {

	private static VerSerieDTOAssembler serieAssembler;

	private VerSerieDTOAssembler(){}

	/**
	 * Singleton
	 * @return instancia unica del assembler
	 */
	public static VerSerieDTOAssembler getInstance(){
		if(serieAssembler==null){
			serieAssembler = new VerSerieDTOAssembler();
		}
		return serieAssembler;
	}

	/**
	 * Metodo que retorna el DTO para la interfaz VerSerie
	 * @param s
	 * @param u
	 * @return DTO de la interfaz VerSerie
	 * @throws NoSeHaPodidoConectarABBDD
	 */
	public VerSerieDTO getSerie(Serie s, Usuario u) throws NoSeHaPodidoConectarABBDD{
		String nombreSerie = s.getNombre();
		String tipoSerie;
		
		if(s instanceof SerieEstandarProxy){
			tipoSerie = "Estandar";		
		}else if(s instanceof SerieGoldProxy){
			tipoSerie= "Gold";
		}else{ //if(s instanceof SerieSilverProxy )
			tipoSerie = "Silver";
		}

		List<TemporadaDTO> temporadas = new LinkedList<TemporadaDTO>();

		for(Temporada t:s.getTemporadas()){
			TemporadaDTO temporada = TemporadaDTOAssembler.getInstance().getTemporada(t,u);
			temporadas.add(temporada);
		}

		return new VerSerieDTO(nombreSerie,tipoSerie,temporadas);
	}

}
