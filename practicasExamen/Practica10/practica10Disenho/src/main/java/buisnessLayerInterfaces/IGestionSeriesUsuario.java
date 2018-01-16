package buisnessLayerInterfaces;

import java.util.List;

import dto.*;
/**
 * Interfaz para gestionar las operaciones que puede realizar un usuario sobre las series
 *
 */
public interface IGestionSeriesUsuario {
	
	/**
	 * Metodo para ver la informacion de una serie
	 * @return informacion de una serie
	 */
	public VerSerieDTO verSerie();
	
	/**
	 * Metodo para listar las series
	 * @return lista de series
	 */
	public List<AgregarSerieDTO> listarSeries();
	
	/**
	 * Metodo para buscar series por su nombre
	 * @param nombre
	 * @return series obtenidas
	 */
	public List<AgregarSerieDTO> buscarSeriesPorNombre(String nombre);
	
	/**
	 * Metodo para buscar series por su letra inicial
	 * @param letraInicial
	 * @return series obtenidas
	 */
	public List<AgregarSerieDTO> buscarSeriesPorLetraInicial(char letraInicial);
	
}
