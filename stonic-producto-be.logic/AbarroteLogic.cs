﻿using stonic_producto_be.data;
using stonic_producto_be.model;

namespace stonic_producto_be.logic
{
    public class AbarroteLogic
    {
        private AbarroteData oProductoData;

        public AbarroteLogic()
        {
            oProductoData = new AbarroteData();
        }

        public ReturnValue Registrar(Producto item)
        {
            ReturnValue oReturn = new ReturnValue();
            try
            {
                oReturn = oProductoData.Registrar(item);
            }
            catch (Exception ex)
            {
                oReturn.Success = false;
                oReturn.Message = "Error no controlado consulte con el administrador. " + ex;
            }
            return oReturn;
        }

    }
}