CREATE SCHEMA IF NOT EXISTS p09diseno;

CREATE TABLE IF NOT EXISTS p09diseno.Creador(
				idCreador int PRIMARY KEY,
				nombre varchar(100) NOT NULL,
				apellido1 varchar(100) NOT NULL,
				apellido2 varchar(100));
				
CREATE TABLE IF NOT EXISTS p09diseno.Serie(
				idSerie int PRIMARY KEY,
				nombre varchar(100) NOT NULL,
				sinopsis varchar(200) NOT NULL,
				costoSerie double(9,3) NOT NULL,
				tipoSerie varchar(20) NOT NULL,
				idCreador int,
				CONSTRAINT fk_serie_creador FOREIGN KEY (idCreador) REFERENCES p09diseno.Creador(idCreador));
				
CREATE TABLE IF NOT EXISTS p09diseno.Temporada(
				idTemporada int PRIMARY KEY,
				numTemporada int NOT NULL,
				idSerie int NOT NULL,
				CONSTRAINT fk_temporada_serie FOREIGN KEY (idSerie) REFERENCES p09diseno.Serie(idSerie));
	
CREATE TABLE IF NOT EXISTS p09diseno.Artista(
				idArtista int PRIMARY KEY,
				nombre varchar(100) NOT NULL,
				apellido1 varchar(100) NOT NULL,
				apellido2 varchar(100));
				
CREATE TABLE IF NOT EXISTS p09diseno.Series_Artistas(
				idArtista int,
				idSerie int,
				CONSTRAINT pk_series_artistas PRIMARY KEY (idSerie,idArtista),
				CONSTRAINT fk_series_artistas_serie FOREIGN KEY (idSerie) REFERENCES p09diseno.Serie(idSerie),
				CONSTRAINT fk_series_artistas_artista FOREIGN KEY (idArtista) REFERENCES p09diseno.Artista(idArtista));
				
CREATE TABLE IF NOT EXISTS p09diseno.Capitulo(
				idCapitulo int PRIMARY KEY,
				numCapitulo varchar(100) NOT NULL,
				idTemporada int NOT NULL,
				titulo varchar(100) NOT NULL,
				enlace varchar(100) NOT NULL,
				CONSTRAINT fk_capitulo_temporada FOREIGN KEY (idTemporada) REFERENCES p09diseno.Temporada(idTemporada));
				
CREATE TABLE IF NOT EXISTS p09diseno.Usuario(
				idUsuario int PRIMARY KEY,
				nombreUsuario int NOT NULL,
				password varchar(30) NOT NULL,
				cuenta_ISBAN varchar(24) NOT NULL,
				cuota varchar(50) NOT NULL);
				
CREATE TABLE IF NOT EXISTS p09diseno.Serie_Usuario(
				idSerie int NOT NULL,
				idUsuario int NOT NULL,
				estado varchar(100) NOT NULL,
				CONSTRAINT pk_temporada_capitulos PRIMARY KEY (idSerie,idUsuario),
				CONSTRAINT fk_serie_usuario_serie FOREIGN KEY (idSerie) REFERENCES p09diseno.Serie(idSerie),
				CONSTRAINT fk_serie_usuario_usuario FOREIGN KEY (idUsuario) REFERENCES p09diseno.Usuario(idUsuario));

CREATE TABLE IF NOT EXISTS p09diseno.Visualizacion(
				idVisualizacion int PRIMARY KEY,
				idCapitulo int NOT NULL,
				idUsuario int NOT NULL,
				fecha date NOT NULL,
				CONSTRAINT fk_visualizacion_serie FOREIGN KEY (idCapitulo) REFERENCES p09diseno.Capitulo(idCapitulo),
				CONSTRAINT fk_visualizacion_usuario FOREIGN KEY (idUsuario) REFERENCES p09diseno.Usuario(idUsuario));		
				
CREATE TABLE IF NOT EXISTS p09diseno.Factura(
				idFactura int PRIMARY KEY,
				fecha date NOT NULL,
				idUsuario int NOT NULL,
				CONSTRAINT fk_factura_usuario FOREIGN KEY (idUsuario) REFERENCES p09diseno.Usuario(idUsuario));		
		
CREATE TABLE IF NOT EXISTS p09diseno.Factura_Visualizacion(
				idVisualizacion int NOT NULL,
				idFactura int NOT NULL,
				CONSTRAINT fk_factura_visualizacion_factura FOREIGN KEY (idFactura) REFERENCES p09diseno.Factura(idFactura),
				CONSTRAINT fk_factura_visualizacion_visualizacion FOREIGN KEY (idVisualizacion) 
					REFERENCES p09diseno.Visualizacion(idVisualizacion));	
