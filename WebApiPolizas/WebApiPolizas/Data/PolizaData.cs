﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApiPolizas.Models;

namespace WebApiPolizas.Data
{
    public class PolizaData
    {
        public static List<Poliza> Listar()
        {
            List<Poliza> listaPolizas = new List<Poliza>();
            using (SqlConnection context = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("pp_listar", context);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    context.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            char inspeccion;

                            if (Convert.ToBoolean(dr["Inspeccion"]))
                            {
                                inspeccion = '1';
                            }
                            else
                            {
                                inspeccion = '0';
                            }

                            listaPolizas.Add(new Poliza()
                            {
                                NumeroPoliza = Convert.ToInt32(dr["NumeroPoliza"]),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                IdCliente = dr["IdCliente"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString()),
                                FechaPoliza = Convert.ToDateTime(dr["FechaPoliza"].ToString()),
                                Coberturas = dr["Coberturas"].ToString(),
                                ValorMaximo = Convert.ToDecimal(dr["ValorMaximo"].ToString()),
                                NombrePoliza = dr["NombrePoliza"].ToString(),
                                CiudadResidencia = dr["CiudadResidencia"].ToString(),
                                DireccionResidencia = dr["DireccionResidencia"].ToString(),
                                PlacaAutomotor = dr["PlacaAutomotor"].ToString(),
                                ModeloAutomotor = dr["ModeloAutomotor"].ToString(),
                                Inspeccion = inspeccion
                            });
                        }

                    }

                    return listaPolizas;
                }
                catch (Exception ex)
                {
                    return listaPolizas;
                }
            }
        }

        public static Poliza Obtener(int numeroPoliza)
        {
            Poliza poliza = new Poliza();
            using (SqlConnection context = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("pp_obtener", context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeropoliza", numeroPoliza);

                try
                {
                    context.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            char inspeccion;

                            if (Convert.ToBoolean(dr["Inspeccion"]))
                            {
                                inspeccion = '1';
                            }
                            else
                            {
                                inspeccion = '0';
                            }

                            poliza = new Poliza()
                            {
                                NumeroPoliza = Convert.ToInt32(dr["NumeroPoliza"]),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                IdCliente = dr["IdCliente"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString()),
                                FechaPoliza = Convert.ToDateTime(dr["FechaPoliza"].ToString()),
                                Coberturas = dr["Coberturas"].ToString(),
                                ValorMaximo = Convert.ToDecimal(dr["ValorMaximo"].ToString()),
                                NombrePoliza = dr["NombrePoliza"].ToString(),
                                CiudadResidencia = dr["CiudadResidencia"].ToString(),
                                DireccionResidencia = dr["DireccionResidencia"].ToString(),
                                PlacaAutomotor = dr["PlacaAutomotor"].ToString(),
                                ModeloAutomotor = dr["ModeloAutomotor"].ToString(),
                                Inspeccion = inspeccion
                            };
                        }

                    }



                    return poliza;
                }
                catch (Exception ex)
                {
                    return poliza;
                }
            }
        }

        public static bool Registrar(Poliza poliza)
        {
            using (SqlConnection context = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("pp_registrar", context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeropoliza", poliza.NumeroPoliza);
                cmd.Parameters.AddWithValue("@nombrecliente", poliza.NombreCliente);
                cmd.Parameters.AddWithValue("@idcliente", poliza.IdCliente);
                cmd.Parameters.AddWithValue("@fechanacimiento", poliza.FechaNacimiento);
                cmd.Parameters.AddWithValue("@fechapoliza", poliza.FechaPoliza);
                cmd.Parameters.AddWithValue("@cobertura", poliza.Coberturas);
                cmd.Parameters.AddWithValue("@valormaximo", poliza.ValorMaximo);
                cmd.Parameters.AddWithValue("@nombrepoliza", poliza.NombrePoliza);
                cmd.Parameters.AddWithValue("@ciudadresidencia", poliza.CiudadResidencia);
                cmd.Parameters.AddWithValue("@direccionresidencia", poliza.DireccionResidencia);
                cmd.Parameters.AddWithValue("@placaautomotor", poliza.PlacaAutomotor);
                cmd.Parameters.AddWithValue("@modeloautomotor", poliza.ModeloAutomotor);
                cmd.Parameters.AddWithValue("@inspeccion", poliza.Inspeccion);

                try
                {
                    context.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool Modificar(Poliza poliza)
        {
            using (SqlConnection context = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("pp_modificar", context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeropoliza", poliza.NumeroPoliza);
                cmd.Parameters.AddWithValue("@nombrecliente", poliza.NombreCliente);
                cmd.Parameters.AddWithValue("@idcliente", poliza.IdCliente);
                cmd.Parameters.AddWithValue("@fechanacimiento", poliza.FechaNacimiento);
                cmd.Parameters.AddWithValue("@fechapoliza", poliza.FechaPoliza);
                cmd.Parameters.AddWithValue("@cobertura", poliza.Coberturas);
                cmd.Parameters.AddWithValue("@valormaximo", poliza.ValorMaximo);
                cmd.Parameters.AddWithValue("@nombrepoliza", poliza.NombrePoliza);
                cmd.Parameters.AddWithValue("@ciudadresidencia", poliza.CiudadResidencia);
                cmd.Parameters.AddWithValue("@direccionresidencia", poliza.DireccionResidencia);
                cmd.Parameters.AddWithValue("@placaautomotor", poliza.PlacaAutomotor);
                cmd.Parameters.AddWithValue("@modeloautomotor", poliza.ModeloAutomotor);
                cmd.Parameters.AddWithValue("@inspeccion", poliza.Inspeccion);

                try
                {
                    context.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (SqlConnection context = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("pp_eliminar", context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeropoliza", id);

                try
                {
                    context.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
