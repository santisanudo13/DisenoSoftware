namespace PatronMixinContexto
{
    /**
     * <summary>
     * Interfaz IPasiego
     * Contiene los metodos necesarios para preparar las comidas caracteristicas de un Pasiego
     * </summary>
     */
    interface IPasiego
    {
        /**
         * <summary> Metodo para hacer un cocido montanes </summary>
         * <returns> String indicando que el cocido se esta haciendo </returns>
         */
        string hacerCocido();

        /**
          * <summary> Metodo para hacer quesada </summary>
          * <returns> String indicando que la quesada se esta haciendo </returns>
          */
        string hacerQuesada();

        /**
         * <summary> Metodo para hacer sobaos </summary>
         * <returns> String indicando que los sobaos se estan haciendo </returns>
         */
        string hacerSobaos();
    }
}