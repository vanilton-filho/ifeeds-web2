import 'dart:convert';

import 'package:ifeeds_app/models/categoria_model.dart';

class AvaliacaoModel {
  String? titulo;
  double? mediaAvaliacao;
  CategoriaModel? categoria;
  String? campus;
  AvaliacaoModel({
    this.titulo,
    this.mediaAvaliacao,
    this.categoria,
    this.campus,
  });

  Map<String, dynamic> toMap() {
    return {
      'titulo': titulo,
      'mediaAvaliacao': mediaAvaliacao,
      'categoria': categoria?.toMap(),
      'campus': campus,
    };
  }

  factory AvaliacaoModel.fromMap(Map<String, dynamic> map) {
    return AvaliacaoModel(
      titulo: map['titulo'],
      mediaAvaliacao: map['mediaAvaliacao'],
      categoria: CategoriaModel.fromMap(map['categoria']),
      campus: map['campus'],
    );
  }

  String toJson() => json.encode(toMap());

  factory AvaliacaoModel.fromJson(String source) =>
      AvaliacaoModel.fromMap(json.decode(source));
}
