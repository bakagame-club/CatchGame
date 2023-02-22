# キャッチゲーム

- プレイヤー（黒い丸）を操作して、得点アイテム（青い四角）をキャッチして、得点を獲得するゲーム
- 敵（赤い四角）にプレイヤーが当たるとゲームオーバー

# 画像の変え方

## 事前準備

- 変更したい画像を`Images`の中に入れる
- 入れた後に`Images > 変更したい画像.png(or .jpg)`を選択
- `Inspector`の中にある`Pixels Per Unit`を画像の縦サイズに変更する
  - たとえば画像が `450px` x `900px`だったら、`Pixels Per Unit`を`900`に設定する

## `SampleScene`

`Player`（プレイヤー）の場合

- `Hierarchy`の中にある`Player`を選択
- `Inspector`の中にある`SpriteRenderer`の`Sprite`の中身を変えれば画像が変わる
  - `Images`からドラッグ&ドロップ

`Enemy`（敵）の場合

- `Prefabs > Enemy`を選択する
- `Inspector > SpriteRenderer > Sprite`の中身を変える
  - `Images`からドラッグ&ドロップ
- 【注意】画像が赤くなるので、`SpriteRenderer > Color`を白に設定する

`Coin`（得点アイテム）の場合

- `Enemy`と同じ
