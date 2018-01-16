package buisnessLayer;

import java.util.List;

import buisnessLayerInterfaces.IGestionSeriesUsuario;
import dto.*;

/**
 * Gestion Series
 *
 */
public class GestionSeries implements IGestionSeriesUsuario {

	/**
	 * Metodo para ver la informacion de una serie
	 * @return informacion de una serie
	 */
	@Override
	public VerSerieDTO verSerie() {
		// TODO Auto-generated method stub
		return null;
	}

	/**
	 * Metodo para listar las series
	 * @return lista de series
	 */
	@Override
	public List<AgregarSerieDTO> listarSeries() {
		// TODO Auto-generated method stub
		return null;
	}

	/**
	 * Metodo para buscar series por su nombre
	 * @param nombre
	 * @return series obtenidas
	 */
	@Override
	public List<AgregarSerieDTO> buscarSeriesPorNombre(String nombre) {
		// TODO Auto-generated method stub
		return null;
	}

	/**
	 * Metodo para buscar series por su letra inicial
	 * @param letraInicial
	 * @return series obtenidas
	 */
	@Override
	public List<AgregarSerieDTO> buscarSeriesPorLetraInicial(char letraInicial) {
		// TODO Auto-generated method stub
		return null;
	}

}
