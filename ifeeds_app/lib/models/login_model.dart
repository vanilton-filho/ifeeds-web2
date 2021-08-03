import 'dart:convert';

import 'package:ifeeds_app/models/usuario_model.dart';

class LoginModel {
  String? matricula;
  String? senha;

  LoginModel({
    this.matricula,
    this.senha,
  });

  Map<String, dynamic> toMap() {
    return {
      'matricula': matricula,
      'senha': senha,
    };
  }

  factory LoginModel.fromMap(Map<String, dynamic> map) {
    return LoginModel(
      matricula: map['matricula'],
      senha: map['senha'],
    );
  }

  String toJson() => json.encode(toMap());

  factory LoginModel.fromJson(String source) =>
      LoginModel.fromMap(json.decode(source));
}

class UsuarioLoginModel {
  final UsuarioModel usuario;
  final String token;

  UsuarioLoginModel({
    required this.usuario,
    required this.token,
  });

  Map<String, dynamic> toMap() {
    return {
      'usuario': usuario.toMap(),
      'token': token,
    };
  }

  factory UsuarioLoginModel.fromMap(Map<String, dynamic> map) {
    return UsuarioLoginModel(
      usuario: UsuarioModel.fromMap(map['usuario']),
      token: map['token'],
    );
  }

  String toJson() => json.encode(toMap());

  factory UsuarioLoginModel.fromJson(String source) =>
      UsuarioLoginModel.fromMap(json.decode(source));
}
