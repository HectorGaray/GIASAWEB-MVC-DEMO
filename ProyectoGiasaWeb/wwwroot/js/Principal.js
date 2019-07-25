class Principal {


    constructor() {
        
    }
    userLink(Urlactual) {


        if (Urlactual == "/Principal" || Urlactual == "/Principal/") {
            document.getElementById("enlace1").classList.add('active');
        }
        if (Urlactual == "/Usuarios" || Urlactual == "/Usuarios/") {
            document.getElementById("enlace2").classList.add('active');
        }
        if (Urlactual == "/Usuarios/Registrar/Registrar" || Urlactual == "/Usuarios/Registrar/Registrar/") {
            document.getElementById("enlace2").classList.add('active');
        }
        if (Urlactual == "/Catalogos" || Urlactual == "/Catalogos/") {
            document.getElementById("enlace3").classList.add('active');
        }
        if (Urlactual == "/Materiales" || Urlactual == "/Materiales/") {
            document.getElementById("enlace4").classList.add('active');
        }


       
    }
}