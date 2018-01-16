package proxy;

import java.util.List;

import domain.Artista;
import domain.Creador;
import domain.Serie;
import domain.Temporada;
import p8.excepciones.NoSeHaPodidoConectarABBDD;


/**
 * Proxy de la SerieEstandar
 *
 */
public class SerieEstandarProxy extends SerieProxy {

	public SerieEstandarProxy(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

}