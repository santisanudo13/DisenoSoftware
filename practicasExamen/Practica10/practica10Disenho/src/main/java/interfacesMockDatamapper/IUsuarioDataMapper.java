package interfacesMockDatamapper;


import domain.Usuario;
import p8.excepciones.NoSeHaPodidoConectarABBDD;


/**
 * Interfaz para los mocks utilizados en la implementacion de los metodos de negocio
 *
 */
public interface IUsuarioDataMapper {
	
	public Usuario insertUsuario(Usuario u) throws NoSeHaPodidoConectarABBDD;

	public void updateUsuario(Usuario u) throws NoSeHaPodidoConectarABBDD;

	public void deleteUsuario(Usuario u) throws NoSeHaPodidoConectarABBDD;

	public Usuario readUsuario(long id) throws NoSeHaPodidoConectarABBDD;

}
