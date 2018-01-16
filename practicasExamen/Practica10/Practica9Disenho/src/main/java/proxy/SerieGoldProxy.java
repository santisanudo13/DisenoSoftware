package proxy;

import java.util.List;

import domain.Artista;
import domain.Creador;
import domain.Serie;
import domain.Temporada;
import p8.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Proxy de la SerieGold
 *
 */
public class SerieGoldProxy extends SerieProxy {

	public SerieGoldProxy(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

	

}
