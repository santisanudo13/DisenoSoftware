namespace PatronMixinContexto
{
    /**
     * <summary> 
     * Interfaz ILebaniego
     * Contiene los metodos necesarios para preparar las comidas caracteristicas de un Lebaniego
     * </summary>
     */
    interface ILebaniego
    {
        /**
         * <summary> Metodo para hacer un cocido lebaniego </summary>
         * <returns> String indicando que el cocido se esta haciendo </returns>
         */
        string hacerCocido();

        /**
         * <summary> Metodo para hacer orujo </summary>
         * <returns> String indicando que el orujo se esta haciendo </returns>
         */
        string hacerOrujo();
    }
}