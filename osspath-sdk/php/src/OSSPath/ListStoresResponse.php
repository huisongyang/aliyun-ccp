<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class ListStoresResponse extends Model
{
    /**
     * @description Store 列表
     *
     * @example
     *
     * @var array
     */
    public $items;
    protected $_name = [
        'items' => 'items',
    ];

    public function validate()
    {
        Model::validateRequired('items', $this->items, true);
    }

    public function toMap()
    {
        $res          = [];
        $res['items'] = [];
        if (null !== $this->items && \is_array($this->items)) {
            $n = 0;
            foreach ($this->items as $item) {
                $res['items'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListStoresResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n            = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? Store::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
