S(function ()
{
    $("#pnRegistro").validate
        ({
            rules:
                {
                    txtDescripcionSolicitud:
                        {
                            maxlenght:1
                        }
                }
        });
}
);