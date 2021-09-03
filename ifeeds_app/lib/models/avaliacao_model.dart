import 'dart:convert';

import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/models/categoria_model.dart';

class AvaliacaoModel {
  int? id;
  String? titulo;
  double? mediaAvaliacao;
  CategoriaModel? categoria;
  CampusModel? campus;
  int? totalFeedbacks;
  AvaliacaoModel({
    this.id,
    this.titulo,
    this.mediaAvaliacao,
    this.categoria,
    this.campus,
    this.totalFeedbacks,
  });

  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'titulo': titulo,
      'mediaAvaliacao': mediaAvaliacao,
      'categoria': categoria?.toMap(),
      'campus': campus?.toMap(),
      'totalFeedbacks': totalFeedbacks,
    };
  }

  factory AvaliacaoModel.fromMap(Map<String, dynamic> map) {
    return AvaliacaoModel(
      id: map['id'],
      titulo: map['titulo'],
      mediaAvaliacao: map['mediaAvaliacao'],
      categoria: CategoriaModel.fromMap(map['categoria']),
      campus: CampusModel.fromMap(map['campus']),
      totalFeedbacks: map['totalFeedbacks'],
    );
  }

  String toJson() => json.encode(toMap());

  factory AvaliacaoModel.fromJson(String source) =>
      AvaliacaoModel.fromMap(json.decode(source));
}
