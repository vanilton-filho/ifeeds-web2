import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/models/usuario_model.dart';
import 'package:ifeeds_app/models/usuario_request_model.dart';
import 'package:ifeeds_app/pages/login/login_page.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/pages/widgets/link_widget.dart';
import 'package:ifeeds_app/services/usuario_service.dart';
import 'package:mask_text_input_formatter/mask_text_input_formatter.dart';

class CadastroUsuarioPage extends StatefulWidget {
  const CadastroUsuarioPage({Key? key}) : super(key: key);

  @override
  _CadastroUsuarioPageState createState() => _CadastroUsuarioPageState();
}

class _CadastroUsuarioPageState extends State<CadastroUsuarioPage> {
  final _formKey = GlobalKey<FormState>();
  final UsuarioRequestModel _usuarioRequestModel = UsuarioRequestModel();

  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(builder: (_, constraints) {
      if (constraints.maxWidth >= 820) {
        return Scaffold(
          backgroundColor: Colors.white,
          body: SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.only(top: 42.0),
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Container(
                        child: Card(
                          elevation: 2,
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(25),
                          ),
                          child: Container(
                            height: 650,
                            width: 800,
                            decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(25),
                              color: Color.fromRGBO(196, 196, 196, 0.32),
                            ),
                            child: Padding(
                              padding: const EdgeInsets.only(top: 40),
                              child: Builder(
                                builder: (context) => Form(
                                  key: _formKey,
                                  child: Padding(
                                      padding: const EdgeInsets.symmetric(
                                          horizontal: 60.0),
                                      child: _formWeb()),
                                ),
                              ),
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ],
              ),
            ),
          ),
        );
      } else if (constraints.maxWidth < 820 && constraints.maxWidth > 680) {
        return Scaffold(
          backgroundColor: Colors.white,
          body: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 40),
            child: Builder(
              builder: (context) => Form(
                key: _formKey,
                child: SingleChildScrollView(
                  child: _formTablet(),
                ),
              ),
            ),
          ),
          bottomNavigationBar: Padding(
            padding: const EdgeInsets.all(8.0),
            child: ButtonWidget(
              buttonStyle: AppButtonStyles.green,
              onPressed: () {
                final form = _formKey.currentState;
                if (form!.validate()) {
                  _cadastrarUsuario(_usuarioRequestModel);
                }
              },
              edgeInsets: const EdgeInsets.symmetric(
                vertical: 21,
                horizontal: 168,
              ),
              label: 'CADASTRAR  >',
              borderCircular: 8,
            ),
          ),
        );
      } else {
        return Scaffold(
          backgroundColor: Colors.white,
          body: Padding(
            padding: const EdgeInsets.only(top: 40),
            child: Builder(
              builder: (context) => Form(
                key: _formKey,
                child: SingleChildScrollView(
                  child: _formMobile(),
                ),
              ),
            ),
          ),
          bottomNavigationBar: Padding(
            padding: const EdgeInsets.all(8.0),
            child: ButtonWidget(
              buttonStyle: AppButtonStyles.green,
              onPressed: () {
                final form = _formKey.currentState;
                if (form!.validate()) {
                  _cadastrarUsuario(_usuarioRequestModel);
                }
              },
              edgeInsets: const EdgeInsets.symmetric(
                vertical: 21,
                horizontal: 168,
              ),
              label: 'CADASTRAR  >',
              borderCircular: 8,
            ),
          ),
        );
      }
    });
  }

  _formWeb() {
    var mask = MaskTextInputFormatter(mask: "(##) #####-####");
    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: _cabecalho(),
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Matrícula',
              prefixIcon: Icons.badge,
              validator: (val) =>
                  (val!.isEmpty) ? 'Por favor, insira sua matrícula' : null,
              onChanged: (valor) => _usuarioRequestModel.matricula = valor,
            ),
            Expanded(child: _buildDropdownButtonCampus(_usuarioRequestModel)),
          ],
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Nome completo',
              prefixIcon: Icons.person,
              validator: (val) =>
                  val!.isEmpty ? 'Forneça seu nome completo' : null,
              onChanged: (valor) => _usuarioRequestModel.nome = valor,
            )
          ],
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Email',
              type: TextInputType.emailAddress,
              prefixIcon: Icons.email,
              validator: (String? val) {
                if (val!.isEmpty) {
                  return "O e-mail é um campo obrigatório";
                } else if (!GetUtils.isEmail(val)) {
                  return "O e-mail não é válido";
                }
              },
              onChanged: (valor) => _usuarioRequestModel.email = valor,
            ),
            FormFieldWidget.expanded(
              label: 'Senha',
              isPassword: true,
              prefixIcon: Icons.lock,
              validator: (val) => val!.length < 8
                  ? 'A senha precisa ter no mínimo 8 caracteres'
                  : null,
              onChanged: (valor) => _usuarioRequestModel.senha = valor,
            ),
          ],
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Telefone',
              masks: [mask],
              type: TextInputType.phone,
              prefixIcon: Icons.phone,
              validator: (val) =>
                  val!.isEmpty ? 'Forneça o seu telefone' : null,
              onChanged: (_) =>
                  _usuarioRequestModel.telefone = mask.getUnmaskedText(),
            ),
            Expanded(child: SizedBox())
          ],
        ),
        Row(children: [
          Expanded(
            child: _buildDropdownButtonTipoConta(_usuarioRequestModel),
          ),
          Expanded(child: SizedBox()),
        ]),
        Expanded(child: SizedBox()),
        Padding(
          padding: const EdgeInsets.only(bottom: 23.0),
          child: ButtonWidget(
            buttonStyle: AppButtonStyles.green,
            onPressed: () {
              final form = _formKey.currentState;
              if (form!.validate()) {
                _cadastrarUsuario(_usuarioRequestModel);
              }
            },
            edgeInsets: const EdgeInsets.symmetric(
              vertical: 21,
              horizontal: 168,
            ),
            label: 'CADASTRAR  >',
            borderCircular: 8,
          ),
        ),
      ],
    );
  }

  _formTablet() {
    var mask = MaskTextInputFormatter(mask: "(##) #####-####");
    return Column(
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: _cabecalho(),
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Matrícula',
              prefixIcon: Icons.badge,
              validator: (val) =>
                  (val!.isEmpty) ? 'Por favor, insira sua matrícula' : null,
              onChanged: (valor) => _usuarioRequestModel.matricula = valor,
            ),
            Expanded(child: _buildDropdownButtonCampus(_usuarioRequestModel)),
          ],
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Nome completo',
              prefixIcon: Icons.person,
              validator: (val) =>
                  val!.isEmpty ? 'Forneça seu nome completo' : null,
              onChanged: (valor) => _usuarioRequestModel.nome = valor,
            )
          ],
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Email',
              type: TextInputType.emailAddress,
              prefixIcon: Icons.email,
              validator: (val) =>
                  val!.isEmpty ? 'Forneça um email válido' : null,
              onChanged: (valor) => _usuarioRequestModel.email = valor,
            ),
            FormFieldWidget.expanded(
              label: 'Senha',
              isPassword: true,
              prefixIcon: Icons.lock,
              validator: (val) => val!.length < 8
                  ? 'A senha precisa ter no mínimo 8 caracteres'
                  : null,
              onChanged: (valor) => _usuarioRequestModel.senha = valor,
            ),
          ],
        ),
        Row(
          children: [
            FormFieldWidget.expanded(
              label: 'Telefone',
              type: TextInputType.phone,
              masks: [mask],
              prefixIcon: Icons.phone,
              validator: (val) =>
                  val!.isEmpty ? 'Forneça o seu telefone' : null,
              onChanged: (_) =>
                  _usuarioRequestModel.telefone = mask.getUnmaskedText(),
            ),
            Expanded(child: SizedBox())
          ],
        ),
        Row(children: [
          Expanded(
            child: _buildDropdownButtonTipoConta(_usuarioRequestModel),
          ),
          Expanded(child: SizedBox()),
        ]),
      ],
    );
  }

  _formMobile() {
    var mask = MaskTextInputFormatter(mask: "(##) #####-####");
    return Column(
      crossAxisAlignment: CrossAxisAlignment.stretch,
      children: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: _cabecalho(size: 21),
        ),
        FormFieldWidget(
          label: 'Matrícula',
          prefixIcon: Icons.badge,
          validator: (val) =>
              (val!.isEmpty) ? 'Por favor, insira sua matrícula' : null,
          onChanged: (valor) => _usuarioRequestModel.matricula = valor,
        ),
        _buildDropdownButtonCampus(_usuarioRequestModel),
        FormFieldWidget(
          label: 'Nome completo',
          prefixIcon: Icons.person,
          validator: (val) => val!.isEmpty ? 'Forneça seu nome completo' : null,
          onChanged: (valor) => _usuarioRequestModel.nome = valor,
        ),
        FormFieldWidget(
          label: 'Email',
          type: TextInputType.emailAddress,
          prefixIcon: Icons.email,
          validator: (val) => val!.isEmpty ? 'Forneça um email válido' : null,
          onChanged: (valor) => _usuarioRequestModel.email = valor,
        ),
        FormFieldWidget(
          label: 'Senha',
          isPassword: true,
          prefixIcon: Icons.lock,
          validator: (val) => val!.length < 8
              ? 'A senha precisa ter no mínimo 8 caracteres'
              : null,
          onChanged: (valor) => _usuarioRequestModel.senha = valor,
        ),
        FormFieldWidget(
          label: 'Telefone',
          type: TextInputType.phone,
          prefixIcon: Icons.phone,
          masks: [mask],
          validator: (val) => val!.isEmpty ? 'Forneça o seu telefone' : null,
          onChanged: (_) =>
              _usuarioRequestModel.telefone = mask.getUnmaskedText(),
        ),
        _buildDropdownButtonTipoConta(_usuarioRequestModel),
      ],
    );
  }

  _buildDropdownButtonTipoConta(UsuarioRequestModel usuarioRequestModel) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: DropdownButtonFormField(
        validator: (val) =>
            val == null ? 'Selecione o tipo de conta para criar' : null,
        isDense: true,
        autovalidateMode: AutovalidateMode.onUserInteraction,
        decoration: const InputDecoration(
            border: OutlineInputBorder(),
            prefixIcon: Icon(Icons.account_circle),
            fillColor: Colors.white,
            focusColor: Colors.red),
        hint: Text("Perfil"),
        // isExpanded: true,
        items: [
          DropdownMenuItem<int>(
            child: Text("Para mim"),
            value: 2,
          ),
          DropdownMenuItem<int>(
            child: Text("Administrador"),
            value: 1,
          ),
        ],
        onChanged: (int? value) {
          setState(() {
            usuarioRequestModel.tipoConta = value;
          });
        },
      ),
    );
  }

  _buildDropdownButtonCampus(UsuarioRequestModel usuarioRequestModel) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: DropdownButtonFormField(
          validator: (val) =>
              val == null ? 'Por favor, informe de qual campus você é' : null,
          isDense: true,
          autovalidateMode: AutovalidateMode.onUserInteraction,
          decoration: const InputDecoration(
            border: OutlineInputBorder(),
            prefixIcon: Icon(Icons.location_city),
            fillColor: Colors.white,
          ),
          hint: Text("Campus"),
          // isExpanded: true,
          items: [
            DropdownMenuItem<int>(
              child: Text("Campus Aracaju"),
              value: 6,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Estância"),
              value: 3,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Glória"),
              value: 2,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Itabaiana"),
              value: 5,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Lagarto"),
              value: 1,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Poço Redondo"),
              value: 8,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Propriá"),
              value: 9,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus São Cristóvão"),
              value: 4,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Socorro"),
              value: 10,
            ),
            DropdownMenuItem<int>(
              child: Text("Campus Tobias Barreto"),
              value: 7,
            ),
            DropdownMenuItem<int>(
              child: Text("Educação à distancia"),
              value: 11,
            ),
          ],
          onChanged: (int? value) {
            setState(() {
              usuarioRequestModel.campusId = value;
            });
          }),
    );
  }

  _cabecalho({double? size = 27.0}) {
    return Row(
      children: [
        RichText(
          text: TextSpan(
            text: 'Criar sua nova conta ',
            style: TextStyle(fontSize: size),
            children: <TextSpan>[
              TextSpan(
                text: 'IFeedS',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: size),
              ),
            ],
          ),
        ),
      ],
    );
  }

  _cadastrarUsuario(UsuarioRequestModel usuarioRequestModel) async {
    var usuarioPayload = usuarioRequestModel.toMap();
    UsuarioModel result = await UsuarioService().cadastrar(usuarioPayload);

    Navigator.push(
        context,
        MaterialPageRoute(
            builder: (context) => Scaffold(
                  body: Center(
                    child: Container(
                      height: 500,
                      child: Padding(
                        padding: const EdgeInsets.only(top: 42.0),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.center,
                          children: [
                            Padding(
                              padding: const EdgeInsets.all(8.0),
                              child: Icon(
                                Icons.check_circle,
                                color: Colors.green,
                                size: 68.0,
                              ),
                            ),
                            Text(
                              '${result.nome}, uhuuu!',
                              style: GoogleFonts.roboto(
                                fontSize: 42.0,
                                fontWeight: FontWeight.bold,
                              ),
                            ),
                            Padding(
                              padding: const EdgeInsets.all(12.0),
                              child: Wrap(
                                children: [
                                  Text(
                                    'Ficamos felizes de ter agora você conosco, aproveite o nosso app ;)',
                                    style: GoogleFonts.roboto(fontSize: 27.0),
                                    textAlign: TextAlign.center,
                                  ),
                                ],
                              ),
                            ),
                            LinkWidget(
                                text: "Retornar para pagina de Login",
                                onTap: () => Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                        builder: (context) => LoginPage(),
                                      ),
                                    ))
                          ],
                        ),
                      ),
                    ),
                  ),
                )));
  }
}
