# NOTE: This file is auto generated by OpenAPI Generator 6.3.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.DeprecatedObject do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :name
  ]

  @type t :: %__MODULE__{
    :name => String.t | nil
  }
end

defimpl Poison.Decoder, for: OpenapiPetstore.Model.DeprecatedObject do
  def decode(value, _options) do
    value
  end
end
